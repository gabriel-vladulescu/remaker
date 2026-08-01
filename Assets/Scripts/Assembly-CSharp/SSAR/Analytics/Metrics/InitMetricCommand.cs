using Scripts.Config;
using Ssar.Achievement;
using strange.extensions.command.impl;

namespace Ssar.Analytics.Metrics
{
	public class InitMetricCommand : Command
	{
		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public bool isUserDataJustInited { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public UserData UserData { get; set; }

		public override void Execute()
		{
		}
	}
}
