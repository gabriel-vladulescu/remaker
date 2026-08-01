using System;
using LitJson;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	[Serializable]
	public class ClaimQuestLog
	{
		[JsonInclude]
		private int questId;

		[JsonInclude]
		private int continuousDayCount;

		[JsonInclude]
		private int lastTimeClaim;

		public ClaimQuestLog(int questId)
		{
		}

		public ClaimQuestLog()
		{
		}

		public void Claim(int currentTime)
		{
		}

		public int GetContinuousDayCount()
		{
			return 0;
		}

		public int GetQuestId()
		{
			return 0;
		}
	}
}
