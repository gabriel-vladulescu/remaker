using System;
using System.Collections.Generic;
using LitJson;

namespace Ssar.Event.Xmas
{
	[Serializable]
	public class XmasWarData
	{
		public int timeGenerate;

		[JsonInclude]
		private List<int> claimedMilestones;

		[JsonInclude]
		private Dictionary<string, int> questProgress;

		[JsonInclude]
		private int totalPoints;

		public void ClaimMilestone(int id)
		{
		}

		public void UpdateQuestProgress(int id, int point, int count = 1)
		{
		}

		public int[] GetClaimedMilestones()
		{
			return null;
		}

		public int GetTotalPoint()
		{
			return 0;
		}

		public bool IsClaimedMilestone(int id)
		{
			return false;
		}
	}
}
