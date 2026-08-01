using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class EnterRaidBossCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public RaidBossConfig.Room Room { get; set; }

		[Inject]
		public RaidTeamData TeamData { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		public override void Execute()
		{
		}

		private void EnterRaidMetric()
		{
		}

		private void AncientMetric(MainCharacterData characterData)
		{
		}
	}
}
