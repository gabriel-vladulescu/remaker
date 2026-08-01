using System.Collections.Generic;
using LitJson;

namespace Scripts.Ssar.Arena
{
	public class DuelArenaTodayData
	{
		[JsonInclude]
		private int participate;

		[JsonInclude]
		private List<int> participateRewardClaimed;

		public void Participate()
		{
		}

		public int GetParticipate()
		{
			return 0;
		}

		public List<int> GetParticipateRewardClaimed()
		{
			return null;
		}

		public void ClaimedReward(int participate)
		{
		}
	}
}
