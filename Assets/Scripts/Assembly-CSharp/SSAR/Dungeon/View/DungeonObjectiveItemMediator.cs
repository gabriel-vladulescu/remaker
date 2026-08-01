using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonObjectiveItemMediator : Mediator
	{
		[Inject]
		public DungeonObjectiveItemView view { get; set; }

		[Inject]
		public UpdateDungeonObjectiveStageItemViewSignal UpdateDungeonObjectiveStageItemViewSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
