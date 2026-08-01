using System.Collections.Generic;
using LitJson;

namespace Ssar.Event.DemonInvasion.Model
{
	public class DemonInvasionRewardData
	{
		[JsonInclude]
		private int timeGenerate;

		[JsonInclude]
		private List<int> claimedRewardsFree;

		[JsonInclude]
		private List<int> claimedRewardsDemon;

		public void ClaimReward(int id, bool demon)
		{
		}

		public bool IsClaimedReward(int id, bool demon)
		{
			return false;
		}
	}
}
