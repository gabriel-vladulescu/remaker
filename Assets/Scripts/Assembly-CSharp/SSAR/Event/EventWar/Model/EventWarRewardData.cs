using System.Collections.Generic;
using LitJson;

namespace Ssar.Event.EventWar.Model
{
	public class EventWarRewardData
	{
		[JsonInclude]
		private int timeGenerate;

		[JsonInclude]
		private List<int> claimedRewards;

		[JsonIgnore]
		public int TimeGenerate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void ClaimReward(int id)
		{
		}

		public bool IsClaimedReward(int id)
		{
			return false;
		}
	}
}
