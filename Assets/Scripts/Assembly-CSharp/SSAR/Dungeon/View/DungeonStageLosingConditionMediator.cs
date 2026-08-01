using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonStageLosingConditionMediator : Mediator
	{
		[Inject]
		public DungeonStageLosingConditionView view { get; set; }

		[Inject]
		public OnEnterDungeonStageSignal OnEnterDungeonStageSignal { get; set; }

		[Inject]
		public OnDungeonStageClearSignal OnDungeonStageClearSignal { get; set; }

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
