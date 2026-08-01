namespace Ssar.Rune
{
	public class RuneSignalManager
	{
		[Inject]
		public ShowRuneManagerPopupSignal ShowRuneManagerPopupSignal { get; set; }

		[Inject]
		public SellRuneSignal SellRuneSignal { get; set; }

		[Inject]
		public ShowSellRunePopupSignal ShowSellRunePopupSignal { get; set; }

		[Inject]
		public ShowCombineRunePopupSignal ShowCombineRunePopupSignal { get; set; }

		[Inject]
		public CombineRuneSignal CombineRuneSignal { get; set; }

		[Inject]
		public ShowViewRuneInfoPopupSignal ShowViewRuneInfoPopupSignal { get; set; }

		[Inject]
		public ShowViewRuneInfoPopupInShopSignal ShowViewRuneInfoPopupInShopSignal { get; set; }

		[Inject]
		public ShowDisassembleRunePopupSignal ShowDisassembleRunePopupSignal { get; set; }

		[Inject]
		public DisassembleRuneSignal DisassembleRuneSignal { get; set; }

		[Inject]
		public ShowChangeRunePopupSignal ShowChangeRunePopupSignal { get; set; }

		[Inject]
		public SelectRuneToEquipSignal SelectRuneToEquipSignal { get; set; }

		[Inject]
		public EquipRuneToSlotSignal EquipRuneToSlotSignal { get; set; }

		[Inject]
		public UnequipRuneSignal UnequipRuneSignal { get; set; }

		[Inject]
		public ReforgeEquipmentWithRuneSignal ReforgeEquipmentWithRuneSignal { get; set; }

		[Inject]
		public ShowReforgeResultConfirmPopupSignal ShowReforgeResultConfirmPopupSignal { get; set; }

		[Inject]
		public ReforgeConfirmTakeNewEquipmentSignal ReforgeConfirmTakeNewEquipmentSignal { get; set; }
	}
}
