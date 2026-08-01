using System;
using System.Collections.Generic;
using LitJson;

namespace Ssar.Event.Xmas
{
	[Serializable]
	public class XmasOnlineData
	{
		public int timeGenerate;

		public int activatedLv;

		[JsonInclude]
		private int lastTimeClaim;

		[JsonInclude]
		private float timeToClaim;

		[JsonInclude]
		private Dictionary<string, int> progress;

		public void ClaimReward()
		{
		}

		public int GetClaimedCount(int day)
		{
			return 0;
		}

		public int GetLastDay()
		{
			return 0;
		}

		public bool IsValidNextTime()
		{
			return false;
		}

		public float GetTimeToClaim()
		{
			return 0f;
		}

		public void SetTimeToClaim(float time)
		{
		}

		public void UpdateTimeToClaim(float deltaTime)
		{
		}
	}
}
