using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DungeonFailedCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

		[Inject]
		public MainCharacterDeathSignal MainCharacterDeathSignal { get; set; }

		[Inject]
		public DungeonLoseByTimeSignal DungeonLoseByTimeSignal { get; set; }

		public override void Execute()
		{
		}

		private void DisableUI()
		{
		}
	}
}
