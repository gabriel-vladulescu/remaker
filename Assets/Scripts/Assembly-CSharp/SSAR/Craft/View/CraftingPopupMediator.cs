using Assets.Scripts.Ssar.Signal;
using Ssar.Craft.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingPopupMediator : Mediator
	{
		[Inject]
		public CraftingPopup view { get; set; }

		[Inject]
		public OnSalvageItemSuccessSignal OnSalvageItemSuccessSignal { get; set; }

		[Inject]
		public OnCraftItemSuccessSignal OnCraftItemSuccessSignal { get; set; }

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
