using System.Collections.Generic;

namespace Scripts.Config
{
	public class ArenaDailyRewardInfo
	{
		public int participate { get; set; }

		public string itemType1 { get; set; }

		public int itemValue1 { get; set; }

		public string itemType2 { get; set; }

		public int itemValue2 { get; set; }

		public string itemType3 { get; set; }

		public int itemValue3 { get; set; }

		public List<ItemInfo> GetItemInfos()
		{
			return null;
		}
	}
}
