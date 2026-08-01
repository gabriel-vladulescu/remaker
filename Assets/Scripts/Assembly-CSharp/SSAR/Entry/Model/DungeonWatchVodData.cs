using System;
using LitJson;

namespace SSAR.Entry.Model
{
	[Serializable]
	public class DungeonWatchVodData
	{
		[JsonInclude]
		private int watchVodBonusExpCount;

		[JsonInclude]
		private int watchVodBonusSoulCount;

		[JsonInclude]
		private int watchVodRandomItemCount;

		public void WatchVodBonusExp()
		{
		}

		public void WatchVodBonusSoul()
		{
		}

		public void WatchVodRandomItem()
		{
		}

		public int GetWatchVodBonusExpCount()
		{
			return 0;
		}

		public int GetWatchVodBonusSoulCount()
		{
			return 0;
		}

		public int GetWatchVodRandomItemCount()
		{
			return 0;
		}

		public void Reset()
		{
		}
	}
}
