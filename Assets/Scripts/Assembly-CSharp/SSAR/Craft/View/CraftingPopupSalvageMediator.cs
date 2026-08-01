using Ssar.Craft.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingPopupSalvageMediator : Mediator
	{
		[Inject]
		public CraftingPopupSalvageView view { get; set; }

		[Inject]
		public OnSelectSalvageItemSignal OnSelectSalvageItemSignal { get; set; }

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
