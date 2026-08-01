using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DungeonWinCommand : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

		public override void Execute()
		{
		}

		private void Invoke()
		{
		}
	}
}
