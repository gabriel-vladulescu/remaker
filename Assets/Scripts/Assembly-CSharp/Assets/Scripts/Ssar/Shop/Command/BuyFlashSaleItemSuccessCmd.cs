using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyFlashSaleItemSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public FlashSaleItemInfo FlashSaleItemInfo { get; set; }

		[Inject]
		public UpdateFlashSaleUISignal UpdateFlashSaleUiSignal { get; set; }

		public override void Execute()
		{
		}

		private void Bought()
		{
		}

		private void AddReward()
		{
		}
	}
}
