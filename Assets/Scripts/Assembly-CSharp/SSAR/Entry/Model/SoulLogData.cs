using System.Collections.Generic;

namespace SSAR.Entry.Model
{
	public class SoulLogData
	{
		public Dictionary<string, int> logAddSoul;

		public Dictionary<string, int> logConsumeSoul;

		public List<string> buyItemButNotConsume;

		public int Delta
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void AddSoul(int value, RewardReason rewardReason)
		{
		}

		public void ConsumeSoul(int value, Reason reason)
		{
		}

		public void ConsumeSoul2(int value, Reason reason)
		{
		}

		public int GetLogAdd(RewardReason reason)
		{
			return 0;
		}
	}
}
