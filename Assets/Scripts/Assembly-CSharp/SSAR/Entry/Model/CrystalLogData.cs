using System;
using System.Collections.Generic;

namespace SSAR.Entry.Model
{
	[Serializable]
	public class CrystalLogData
	{
		public Dictionary<string, int> logAddCrystal;

		public Dictionary<string, int> logConsumeCrystal;

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

		public void ResetLog()
		{
		}

		public void ResetLogAddAndConsume()
		{
		}

		public void AddCrystal(int value, RewardReason rewardReason)
		{
		}

		public void ConsumeCrystal(int value, Reason reason)
		{
		}

		public void ConsumeCrystal2(int value, Reason reason)
		{
		}

		public int GetLogAdd(RewardReason reason)
		{
			return 0;
		}
	}
}
