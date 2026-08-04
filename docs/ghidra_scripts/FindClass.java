import ghidra.app.script.GhidraScript;
import ghidra.program.model.listing.Function;
import ghidra.program.model.listing.FunctionManager;

public class FindClass extends GhidraScript {
	@Override
	public void run() throws Exception {
		String[] needles = {
			"GameInitController", "TitleSceneView", "MovementSystem",
			"HeroStateMachine", "InitDungeonSystemCmd", "LoadingSceneView",
			"MainScenePopup", "CameraComponent", "DungeonFactory"
		};
		FunctionManager fm = currentProgram.getFunctionManager();
		for (String needle : needles) {
			int count = 0;
			println("=== " + needle + " ===");
			for (Function f : fm.getFunctions(true)) {
				String name = f.getName();
				if (name != null && name.contains(needle)) {
					if (count < 8) {
						println("  " + f.getEntryPoint() + "  " + name);
					}
					count++;
				}
			}
			println("  (" + count + " matches)");
		}
	}
}
