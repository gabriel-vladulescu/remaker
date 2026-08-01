using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Achievement.Command
{
	public class ClaimAchievementCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public JsonAchievementConfig.AchievementItem AchievementItem { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendMetric()
		{
		}
	}
}
