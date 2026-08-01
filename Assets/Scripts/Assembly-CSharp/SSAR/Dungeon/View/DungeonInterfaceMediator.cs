using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonInterfaceMediator : Mediator
	{
		[Inject]
		public DungeonInterfaceView view { get; set; }

		[Inject]
		public OnDungeonStartSignal OnDungeonStartSignal { get; set; }

		[Inject]
		public OnEnterDungeonStageSuccessSignal OnEnterDungeonStageSignal { get; set; }

		[Inject]
		public HideMainCharacterHealthInfoSignal HideMainCharacterHealthInfoSignal { get; set; }

		[Inject]
		public HideDungeonObjectiveSignal HideDungeonObjectiveSignal { get; set; }

		[Inject]
		public HideDungeonStageViewSignal HideDungeonStageViewSignal { get; set; }

		[Inject]
		public OnChangeDungeonWaveSignal OnChangeDungeonWaveSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void Destroy()
		{
		}
	}
}
