import ghidra.app.script.GhidraScript;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.program.model.symbol.SourceType;
import com.google.gson.stream.JsonReader;
import java.io.FileReader;
import java.io.BufferedReader;
import java.util.ArrayList;

public class LabelIl2Cpp extends GhidraScript {

	private Address base;

	@Override
	public void run() throws Exception {
		String[] args = getScriptArgs();
		if (args.length < 1) {
			println("Usage: LabelIl2Cpp.java <script.json path>");
			return;
		}
		base = currentProgram.getImageBase();

		JsonReader reader = new JsonReader(new BufferedReader(new FileReader(args[0])));
		reader.beginObject();
		while (reader.hasNext()) {
			if (monitor.isCancelled()) {
				break;
			}
			String key = reader.nextName();
			switch (key) {
				case "ScriptMethod":
				case "ScriptMetadata":
					println("Processing " + key + "...");
					processNamedEntries(reader);
					break;
				case "ScriptMetadataMethod":
					println("Processing ScriptMetadataMethod...");
					processNamedEntries(reader);
					break;
				case "ScriptString":
					println("Processing ScriptString...");
					processStrings(reader);
					break;
				case "Addresses":
					println("Processing Addresses...");
					processAddresses(reader);
					break;
				default:
					reader.skipValue();
			}
		}
		reader.endObject();
		reader.close();
		println("Script finished!");
	}

	private void processNamedEntries(JsonReader reader) throws Exception {
		reader.beginArray();
		int count = 0;
		int labeled = 0;
		while (reader.hasNext()) {
			if (monitor.isCancelled()) {
				break;
			}
			reader.beginObject();
			long addrVal = 0;
			String name = null;
			while (reader.hasNext()) {
				String field = reader.nextName();
				switch (field) {
					case "Address":
						addrVal = reader.nextLong();
						break;
					case "Name":
						name = reader.nextString();
						break;
					default:
						reader.skipValue();
				}
			}
			reader.endObject();
			if (name != null) {
				Address addr = base.add(addrVal);
				String safeName = name.replace(' ', '-');
				try {
					createLabel(addr, safeName, true, SourceType.USER_DEFINED);
					setEOLComment(addr, name);
					labeled++;
				}
				catch (Exception e) {
					// duplicate/invalid name, skip
				}
			}
			count++;
			if (count % 10000 == 0) {
				println("  ..." + count + " processed (" + labeled + " labeled)");
			}
		}
		reader.endArray();
		println("  done: " + count + " processed, " + labeled + " labeled");
	}

	private void processStrings(JsonReader reader) throws Exception {
		reader.beginArray();
		int index = 1;
		while (reader.hasNext()) {
			if (monitor.isCancelled()) {
				break;
			}
			reader.beginObject();
			long addrVal = 0;
			String value = null;
			while (reader.hasNext()) {
				String field = reader.nextName();
				switch (field) {
					case "Address":
						addrVal = reader.nextLong();
						break;
					case "Value":
						value = reader.nextString();
						break;
					default:
						reader.skipValue();
				}
			}
			reader.endObject();
			Address addr = base.add(addrVal);
			try {
				createLabel(addr, "StringLiteral_" + index, true, SourceType.USER_DEFINED);
				if (value != null) {
					setEOLComment(addr, value);
				}
			}
			catch (Exception e) {
				// duplicate/invalid, skip
			}
			index++;
			if (index % 10000 == 0) {
				println("  ..." + index + " strings processed");
			}
		}
		reader.endArray();
		println("  done: " + (index - 1) + " strings processed");
	}

	private void processAddresses(JsonReader reader) throws Exception {
		reader.beginArray();
		ArrayList<Long> addrs = new ArrayList<>();
		while (reader.hasNext()) {
			addrs.add(reader.nextLong());
		}
		reader.endArray();

		int total = Math.max(0, addrs.size() - 1);
		println("  creating up to " + total + " functions...");
		int created = 0;
		for (int i = 0; i < total; i++) {
			if (monitor.isCancelled()) {
				break;
			}
			Address addr = base.add(addrs.get(i));
			Function f = getFunctionAt(addr);
			if (f == null) {
				try {
					createFunction(addr, null);
					created++;
				}
				catch (Exception e) {
					// skip
				}
			}
			if (i % 10000 == 0) {
				println("  ..." + i + "/" + total + " (" + created + " created)");
			}
		}
		println("  done: " + created + " functions created");
	}
}
