using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class CheckDungeonCanResurrectionCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShowdDungeonResurrectionPopupSignal ShowdDungeonResurrectionPopupSignal { get; set; }

		[Inject]
		public LoseBattleSignal ShowDungeonLosePopupSignal { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		public bool CanResurrection()
		{
			return false;
		}
	}
}
