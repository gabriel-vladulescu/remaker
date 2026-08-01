using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuySoulCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShopSoulProductInfo ShopSoulProductInfo { get; set; }

		public override void Execute()
		{
		}
	}
}
