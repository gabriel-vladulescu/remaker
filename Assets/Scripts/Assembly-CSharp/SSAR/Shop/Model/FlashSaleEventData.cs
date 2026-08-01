using System.Collections.Generic;
using LitJson;

namespace Ssar.Shop.Model
{
	public class FlashSaleEventData
	{
		[JsonInclude]
		private List<int> itemIds;

		[JsonInclude]
		private List<int> itemHasBought;

		[JsonInclude]
		private int endTime;

		[JsonInclude]
		private int nexTimeAppear;

		public void GenerateNewData(List<int> itemIds, int endTime, int nextTimeAppear)
		{
		}

		public void RefreshListItem(List<int> itemIds)
		{
		}

		public List<int> GetListItem()
		{
			return null;
		}

		private void SetEndTime(int endTime)
		{
		}

		public int GetEndTime()
		{
			return 0;
		}

		private void SetNextTimeAppear(int nextTimeAppear)
		{
		}

		public int GetNextTimeAppear()
		{
			return 0;
		}

		public bool HasBought(int itemId)
		{
			return false;
		}

		public void BoughtItem(int itemId)
		{
		}
	}
}
