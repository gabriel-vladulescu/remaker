using Ssar.Craft.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftableItemInventoryItemMediator : Mediator
	{
		[Inject]
		public CraftableItemInventoryItemView view { get; set; }

		[Inject]
		public OnUpdateCraftingDataSignal OnUpdateCraftingDataSignal { get; set; }

		[Inject]
		public OnCraftItemSuccessSignal OnCraftItemSuccessSignal { get; set; }

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
