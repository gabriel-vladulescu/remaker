namespace Ssar.Craft.Model
{
	public class CraftingSignalManager
	{
		[Inject]
		public ShowCraftingPopupSignal ShowCraftingPopupSignal { get; set; }

		[Inject]
		public ShowCraftingMaterialManagerPopupSignal ShowCraftingMaterialManagerPopupSignal { get; set; }

		[Inject]
		public ShowSellMaterialPopupSignal ShowSellMaterialPopupSignal { get; set; }

		[Inject]
		public ShowCraftingMaterialInfoPopupSignal ShowCraftingMaterialInfoPopupSignal { get; set; }

		[Inject]
		public ShowCraftItemSuccessPopupSignal ShowCraftItemSuccessPopupSignal { get; set; }

		[Inject]
		public ShowCraftableItemFilterPopupSignal ShowCraftableItemFilterPopupSignal { get; set; }

		[Inject]
		public OnSelectSalvageItemSignal OnSelectSalvageItemSignal { get; set; }

		[Inject]
		public OnUpdateCraftingDataSignal OnUpdateCraftingDataSignal { get; set; }

		[Inject]
		public SelectItemToSalvageSignal SelectItemToSalvageSignal { get; set; }

		[Inject]
		public ExtractItemToMaterialSignal ExtractItemToMaterialSignal { get; set; }

		[Inject]
		public CraftItemSignal CraftItemSignal { get; set; }

		[Inject]
		public SellMaterialSignal SellMaterialSignal { get; set; }

		[Inject]
		public ReceiveCraftItemSignal ReceiveCraftItemSignal { get; set; }

		[Inject]
		public ClaimCraftInitRewardsSignal ClaimCraftInitRewardsSignal { get; set; }
	}
}
