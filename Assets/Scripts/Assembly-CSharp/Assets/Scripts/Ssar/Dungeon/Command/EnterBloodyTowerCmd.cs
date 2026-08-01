using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class EnterBloodyTowerCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BloodyTowerFloorInfo info { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		public override void Execute()
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}

		private void AncientMetric(MainCharacterData characterData)
		{
		}
	}
}
