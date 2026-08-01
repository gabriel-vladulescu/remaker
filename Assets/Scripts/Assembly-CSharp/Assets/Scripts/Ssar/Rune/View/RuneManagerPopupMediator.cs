using Assets.Scripts.Ssar.Signal;
using Ssar.Rune;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneManagerPopupMediator : Mediator
	{
		[Inject]
		public RuneManagerPopup view { get; set; }

		[Inject]
		public OnSellRuneSuccessSignal OnSellRuneSuccessSignal { get; set; }

		[Inject]
		public OnCombineRuneSuccessSignal OnCombineRuneSuccessSignal { get; set; }

		[Inject]
		public OnDisassembleRuneSuccessSignal OnDisassembleRuneSuccessSignal { get; set; }

		[Inject]
		public SelectRuneToEquipSignal SelectRuneToEquipSignal { get; set; }

		[Inject]
		public OnEquipRuneSuccessSignal OnEquipRuneSuccessSignal { get; set; }

		[Inject]
		public OnUnEquipRuneSuccessSignal OnUnEquipRuneSuccessSignal { get; set; }

		[Inject]
		public OnReforgeEquipmentWithRuneSuccessSignal OnReforgeEquipmentWithRuneSuccessSignal { get; set; }

		[Inject]
		public OnReforgeResultConfirmedSignal OnReforgeResultConfirmedSignal { get; set; }

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
