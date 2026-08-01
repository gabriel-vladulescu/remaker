using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

namespace Ssar.Shop.Model
{
	public class DoubleExpBoughtData
	{
		[JsonInclude]
		private ObscuredInt timePurchased;

		[JsonInclude]
		private ObscuredInt duration;

		public void Purchase(int currentTime, int duration)
		{
		}

		public int GetTimePurchased()
		{
			return 0;
		}

		public int GetDuration()
		{
			return 0;
		}
	}
}
