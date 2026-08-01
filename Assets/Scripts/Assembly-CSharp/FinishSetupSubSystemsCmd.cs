using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

public class FinishSetupSubSystemsCmd : Command
{
	[Inject]
	public LoadStartSceneSignal LoadStartSceneSignal { get; set; }

	public override void Execute()
	{
	}
}
