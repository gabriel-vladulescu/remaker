using LitJson;

namespace Ssar.Shop.Model
{
	public class FlashSaleOreRuneBoughtData
	{
		[JsonInclude]
		private int endTime;

		[JsonInclude]
		private int nexTimeAppear;

		[JsonInclude]
		private bool receivedUltimateItem;

		[JsonInclude]
		private bool hasShowPopup;

		[JsonIgnore]
		public bool ReceivedUltimateItem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public bool HasShowPopup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void SetEndTime(int endTime)
		{
		}

		public int GetEndTime()
		{
			return 0;
		}

		public void SetNextTimeAppear(int nextTimeAppear)
		{
		}

		public int GetNextTimeAppear()
		{
			return 0;
		}
	}
}
