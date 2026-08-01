using System;
using LitJson;
using Ssar.DailyChallenge.Model;

namespace Ssar.Event.EventWar.Model
{
	[Serializable]
	public class EventWarData
	{
		[JsonInclude]
		private string eventId;

		[JsonInclude]
		private DailyChalllengeData dailyChalllengeData;

		[JsonInclude]
		private WarTokenData tokenData;

		[JsonInclude]
		private EventWarRewardData rewardData;

		[JsonInclude]
		private int lastTimeInteract;

		public string EventId => null;

		[JsonIgnore]
		public DailyChalllengeData DailyChalllengeData => null;

		[JsonIgnore]
		public int Token => 0;

		[JsonIgnore]
		public EventWarRewardData RewardData => null;

		public EventWarData()
		{
		}

		public EventWarData(string eventId)
		{
		}

		public void AddToken(int token, RewardReason source)
		{
		}

		private void OnInteracted()
		{
		}
	}
}
