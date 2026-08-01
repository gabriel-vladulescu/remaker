using System.Collections.Generic;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.Craft.Model;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Ssar.Craft.Command
{
	public class ExtractItemToMaterialCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ExtractItemToMaterialParameter Parameter { get; set; }

		[Inject]
		public OnSalvageItemSuccessSignal SuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		public override void Execute()
		{
		}

		private CraftingMaterial[] ExtractToMaterials()
		{
			return null;
		}

		private List<ItemInfo> ConvertToReward(CraftingMaterial[] materials)
		{
			return null;
		}

		private void DeleteItem()
		{
		}

		private void SendSalvageMetric(int quantity)
		{
		}
	}
}
