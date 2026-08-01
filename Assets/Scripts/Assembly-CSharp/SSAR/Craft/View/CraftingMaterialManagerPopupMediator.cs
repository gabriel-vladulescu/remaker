using Ssar.Craft.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingMaterialManagerPopupMediator : Mediator
	{
		[Inject]
		public CraftingMaterialManagerPopup view { get; set; }

		[Inject]
		public OnSellMaterialSuccessSignal OnSellMaterialSuccessSignal { get; set; }

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
