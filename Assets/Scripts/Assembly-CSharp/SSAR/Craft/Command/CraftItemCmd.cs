using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using Ssar.Craft.Model;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Ssar.Craft.Command
{
	public class CraftItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CrafItemParameter Parameter { get; set; }

		[Inject]
		public OnUpdateCraftingDataSignal updateDataSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		public override void Execute()
		{
		}

		private void Craft(CrafItemParameter parameter)
		{
		}

		private void ConsumMaterials(ItemCraftingLogic craftingLogic)
		{
		}

		private void OnSuccess()
		{
		}

		private void SendCraftMetric(string equipmentType, Rarity rarity, int soulCost)
		{
		}

		private void SendAncientCraftMetric()
		{
		}
	}
}
