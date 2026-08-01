using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.SkillSystem.Command
{
	public class ChangeControllerLayoutCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int controllerId { get; set; }

		[Inject]
		public OnChangeControllerLayoutSignal OnChangeControllerLayoutSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
