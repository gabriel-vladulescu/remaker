using System.Collections.Generic;

namespace SSAR.Entry.Model
{
	public class RuneLogData
	{
		public Dictionary<string, int> logAdd;

		public Dictionary<string, int> logConsume;

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

		public void Add(int value, RewardReason rewardReason)
		{
		}

		public void Consume(int value, ConsumeRuneReason reason)
		{
		}

		public void BuyItemButNotConsume(int value, ConsumeRuneReason reason)
		{
		}
	}
}
