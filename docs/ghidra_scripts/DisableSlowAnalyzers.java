import ghidra.app.script.GhidraScript;
import ghidra.program.model.listing.Program;
import ghidra.framework.options.Options;

public class DisableSlowAnalyzers extends GhidraScript {
	@Override
	public void run() throws Exception {
		Options options = currentProgram.getOptions(Program.ANALYSIS_PROPERTIES);
		options.setBoolean("GCC Exception Handlers", false);
		println("Disabled GCC Exception Handlers analyzer");
	}
}
