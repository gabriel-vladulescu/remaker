import ghidra.app.script.GhidraScript;
import ghidra.program.model.listing.Function;
import ghidra.program.model.listing.FunctionManager;
import ghidra.program.model.symbol.Symbol;
import ghidra.program.model.symbol.SymbolIterator;
import ghidra.program.model.symbol.SymbolTable;

public class VerifyLabels extends GhidraScript {
	@Override
	public void run() throws Exception {
		FunctionManager fm = currentProgram.getFunctionManager();
		int total = fm.getFunctionCount();
		println("Total functions: " + total);

		int shown = 0;
		int namedCount = 0;
		for (Function f : fm.getFunctions(true)) {
			String name = f.getName();
			if (name != null && (name.contains("$$") || name.contains("::"))) {
				namedCount++;
				if (shown < 15) {
					println("  " + f.getEntryPoint() + "  " + name);
					shown++;
				}
			}
		}
		println("Functions with real C#-style names ($$/::): " + namedCount + " / " + total);

		SymbolTable st = currentProgram.getSymbolTable();
		int stringCount = 0;
		SymbolIterator it = st.getSymbolIterator("StringLiteral_*", true);
		while (it.hasNext()) {
			it.next();
			stringCount++;
		}
		println("StringLiteral_* symbols: " + stringCount);
	}
}
