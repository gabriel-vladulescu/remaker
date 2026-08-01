using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DisableInputAndAICmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public bool disable { get; set; }

		public override void Execute()
		{
		}
	}
}
