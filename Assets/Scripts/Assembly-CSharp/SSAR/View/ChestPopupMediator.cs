using Assets.Scripts.Ssar.Signal;
using Ssar.Craft.Model;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class ChestPopupMediator : Mediator
	{
		[Inject]
		public ChestPopup view { get; set; }

		[Inject]
		public OnBuyTreasureSuccessSignal OnBuyTreasureSuccessSignal { get; set; }

		[Inject]
		public OnSalvageItemSuccessSignal OnSalvageItemSuccessSignal { get; set; }

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
