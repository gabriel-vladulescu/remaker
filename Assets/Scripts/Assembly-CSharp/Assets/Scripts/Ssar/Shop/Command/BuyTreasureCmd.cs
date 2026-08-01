using System.Collections.Generic;
using Assets.Scripts.Ssar.Signal;
using SSAR.Shop.Enum;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyTreasureCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShopTreasureProductInfo ProductInfo { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		[Inject]
		public OnBuyTreasureSuccessSignal OnBuyTreasureSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void UpdateFreeEquipmentData()
		{
		}

		private void SendBuyCardMetric()
		{
		}

		private void Buy()
		{
		}

		private void OnFinishFx()
		{
		}

		private void AddToInventory(List<ItemInfo> equipmentConfigIds)
		{
		}

		private List<ItemInfo> GeneratItem(ShopTreasureProductInfo productInfo)
		{
			return null;
		}

		private ItemInfo GenerateItem(int id, ShopTreastureType type)
		{
			return null;
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}

		private void UpdateCampaignQuest()
		{
		}
	}
}
