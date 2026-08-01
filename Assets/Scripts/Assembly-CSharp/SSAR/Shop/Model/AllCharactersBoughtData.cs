using LitJson;

namespace Ssar.Shop.Model
{
	public class AllCharactersBoughtData
	{
		[JsonInclude]
		private int endTime;

		[JsonInclude]
		private int nexTimeAppear;

		[JsonInclude]
		private bool hasShowPopup;

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
