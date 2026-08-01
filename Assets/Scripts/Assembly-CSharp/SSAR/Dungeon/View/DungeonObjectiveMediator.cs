using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonObjectiveMediator : Mediator
	{
		[Inject]
		public DungeonObjectiveView view { get; set; }

		[Inject]
		public UpdateDungeonObjectiveListStageSignal UpdateDungeonObjectiveListStageSignal { get; set; }

		[Inject]
		public DungeonWinSignal DungeonWinSignal { get; set; }

		[Inject]
		public LoseBattleSignal ShowDungeonLosePopupSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void Lose(DungeonLoseReason lose)
		{
		}
	}
}
