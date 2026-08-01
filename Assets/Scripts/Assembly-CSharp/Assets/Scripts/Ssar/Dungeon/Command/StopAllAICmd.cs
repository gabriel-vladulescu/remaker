using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class StopAllAICmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public bool stop { get; set; }

		public override void Execute()
		{
		}
	}
}
