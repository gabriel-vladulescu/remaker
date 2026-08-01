using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class RefreshShopVendorCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendResetVendorMetric(MainCharacterData main)
		{
		}
	}
}
