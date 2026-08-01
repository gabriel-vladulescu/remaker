using System.Collections.Generic;

namespace SSAR.Entry.Model
{
	public class CraftingMaterialLogData
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

		public void Consume(int value, ConsumeCraftingMaterialReason reason)
		{
		}

		public void BuyItemButNotConsume(int value, ConsumeCraftingMaterialReason reason)
		{
		}
	}
}
