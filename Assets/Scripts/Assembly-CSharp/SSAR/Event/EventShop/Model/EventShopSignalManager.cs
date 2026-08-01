namespace Ssar.Event.EventShop.Model
{
	public class EventShopSignalManager
	{
		[Inject]
		public OnBuyEventTokenSuccessSignal OnBuyEventTokenSuccessSignal { get; set; }

		[Inject]
		public BuyEventTokenSignal BuyEventTokenSignal { get; set; }
	}
}
