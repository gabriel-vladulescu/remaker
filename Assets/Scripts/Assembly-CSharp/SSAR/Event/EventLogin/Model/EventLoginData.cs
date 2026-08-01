using LitJson;

namespace Ssar.Event.EventLogin.Model
{
	public class EventLoginData
	{
		[JsonInclude]
		private int timeGenerate;

		[JsonInclude]
		private int lastClaimDay;

		[JsonInclude]
		private int lastTimeClaim;

		[JsonIgnore]
		public int LastClaimDay => 0;

		[JsonIgnore]
		public int LastTimeClaim => 0;

		public void ClaimReward(int day)
		{
		}
	}
}
