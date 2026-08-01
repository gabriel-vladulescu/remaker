namespace Scripts.Config
{
	public class ScenarioStarChestRewardInfo
	{
		public int id { get; set; }

		public int mapId { get; set; }

		public int requireStar { get; set; }

		public string rewardType { get; set; }

		public int value { get; set; }

		public int quantity { get; set; }

		public string difficulty { get; set; }

		public ItemInfo GetItemInfo()
		{
			return null;
		}

		private ItemType GetItemType()
		{
			return default(ItemType);
		}

		public ScenarioDifficulty GetDifficulty()
		{
			return default(ScenarioDifficulty);
		}
	}
}
