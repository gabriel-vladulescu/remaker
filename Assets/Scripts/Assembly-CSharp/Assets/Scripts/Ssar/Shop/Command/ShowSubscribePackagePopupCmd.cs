using Assets.Scripts.Ssar.Shop.Model;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowSubscribePackagePopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ISubscribePackageLogic parameter { get; set; }

		[Inject]
		public ShowSubscribePackageParameters showParamater { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}

		private void SendShowPackageBundleMetric()
		{
		}
	}
}
