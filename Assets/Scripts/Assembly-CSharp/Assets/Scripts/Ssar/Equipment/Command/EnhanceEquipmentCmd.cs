using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Scripts.Ssar.Pet;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class EnhanceEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IItem EquipmentCollectData { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		public override void Execute()
		{
		}

		private void SendUpgradePetMetric(PetCollectData petCollectData)
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}
	}
}
