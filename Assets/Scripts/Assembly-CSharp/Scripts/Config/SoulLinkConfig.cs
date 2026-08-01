using System.Collections.Generic;

namespace Scripts.Config
{
	public class SoulLinkConfig : IConfig
	{
		public class Constants
		{
			public bool enabled { get; set; }

			public int[] characterOrder { get; set; }
		}

		public class BonusInfo
		{
			public int characterId { get; set; }

			public string type { get; set; }

			public double maxBonus { get; set; }

			public BonusType BonusType => default(BonusType);
		}

		public class Milestone
		{
			public int characterId { get; set; }

			public int powerThreshold { get; set; }

			public double bonus { get; set; }
		}

		public enum BonusType
		{
			INCREASE_ITEM_DROP_RATE = 0,
			INCREASE_AWAKEN_EXP = 1,
			INCREASE_MASTERY_EXP = 2,
			INCREASE_CHANCE_HIGHER_ESSENCE = 3
		}

		public Dictionary<string, Constants> constants;

		public Dictionary<string, BonusInfo> bonusInfos;

		public Dictionary<string, Milestone> milestones;

		private Dictionary<int, List<Milestone>> dictMilestones;

		public void OnMapValue(string content)
		{
		}

		public Constants GetConfigConstants()
		{
			return null;
		}

		public bool FindBonusInfo(BonusType bonusType, out BonusInfo info)
		{
			info = null;
			return false;
		}

		public bool FindBonusInfo(int characterId, out BonusInfo info)
		{
			info = null;
			return false;
		}

		public bool FindMilestone(int characterId, int power, ref Milestone milestone)
		{
			return false;
		}

		public bool FindNextMilestone(int characterId, int power, ref Milestone milestone)
		{
			return false;
		}

		public Milestone GetLowestMilestone(int characterId)
		{
			return null;
		}

		private int CompareMilestone(Milestone a, Milestone b)
		{
			return 0;
		}
	}
}
