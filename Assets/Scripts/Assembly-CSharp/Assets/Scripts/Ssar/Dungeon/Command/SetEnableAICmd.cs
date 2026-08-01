using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SetEnableAICmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public bool enable { get; set; }

		public override void Execute()
		{
		}
	}
}
