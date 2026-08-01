using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Mastery
{
	public class MasteryPopupMediator : Mediator
	{
		[Inject]
		public OnTrainMasterySuccessSignal OnTrainMasterySuccessSignal { get; set; }

		[Inject]
		public MasteryPopup view { get; set; }

		[Inject]
		public SelectMasteryToTrainSignal SelectMasteryToTrainSignal { get; set; }

		[Inject]
		public HideTrainMasteryContainerSignal HideTrainMasteryContainerSignal { get; set; }

		[Inject]
		public OnAddMaterialToTrainMasterySignal OnAddMaterialToTrainMasterySignal { get; set; }

		[Inject]
		public OnRemoveMaterialToTrainMasterySignal OnRemoveMaterialToTrainMasterySignal { get; set; }

		[Inject]
		public OnBuyTreasureSuccessSignal OnBuyTreasureSuccessSignal { get; set; }

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
