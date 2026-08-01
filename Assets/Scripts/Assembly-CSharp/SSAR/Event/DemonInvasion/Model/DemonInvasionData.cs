using System;
using LitJson;
using Ssar.DailyChallenge.Model;

namespace Ssar.Event.DemonInvasion.Model
{
	[Serializable]
	public class DemonInvasionData
	{
		[JsonInclude]
		private string eventId;

		[JsonInclude]
		private DailyChalllengeData dailyChallengeData;

		[JsonInclude]
		private DemonInvasionTokenData tokenData;

		[JsonInclude]
		private DemonInvasionRewardData rewardData;

		[JsonInclude]
		private DemonInvasionRewardData dailyGiftData;

		[JsonInclude]
		private bool isUnlockDemonPass;

		[JsonInclude]
		private int lastTimeInteract;

		[JsonInclude]
		private int indexRank;

		public int IndexRank
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public DemonInvasionData()
		{
		}

		public DemonInvasionData(string id)
		{
		}

		public DailyChalllengeData DailyChallengeData()
		{
			return null;
		}

		public string EventId()
		{
			return null;
		}

		public bool GetUnlockDemonPass()
		{
			return false;
		}

		public void SetUnlockDemonPass()
		{
		}

		public DemonInvasionRewardData GetRewardData()
		{
			return null;
		}

		public DemonInvasionRewardData GetDailyGiftData()
		{
			return null;
		}

		public int Token()
		{
			return 0;
		}

		public void AddToken(int token, RewardReason source)
		{
		}

		private void OnInteracted()
		{
		}
	}
}
