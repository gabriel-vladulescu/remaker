using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class DailyChallengeRewardConfig : IConfig
	{
		public class Pool
		{
			private readonly List<RewardRate> rewardRates;

			public ScenarioDifficulty difficulty { get; set; }

			public int roundOrder { get; set; }

			public RewardRate[] RewardRates => null;

			public Pool(ScenarioDifficulty difficulty, int roundOrder)
			{
			}

			public void AddReward(Reward reward)
			{
			}

			public void Validate()
			{
			}
		}

		public class RewardRate
		{
			private int id;

			private double rate;

			public int Id => 0;

			public double Rate => 0.0;

			public RewardRate(int id, double rate)
			{
			}
		}

		public class Reward
		{
			private ItemInfo rewardItem;

			private ObscuredInt obscuredValue;

			private ObscuredInt obscuredQuantity;

			public int id { get; set; }

			public string difficulty { get; set; }

			public int roundOrder { get; set; }

			public string type { get; set; }

			public double rate { get; set; }

			public int value
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int quantity
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public ItemInfo RewardItem => null;

			public ItemType ItemType => default(ItemType);

			public void Parse()
			{
			}

			public ScenarioDifficulty GetDifficulty()
			{
				return default(ScenarioDifficulty);
			}
		}

		public Dictionary<string, Reward> rewards;

		private Dictionary<string, Pool> pools;

		public void OnMapValue(string content)
		{
		}

		public bool FindRewardPoolByRoundOrder(ScenarioDifficulty difficulty, int order, ref Pool rewardPool)
		{
			return false;
		}

		public Pool[] GetPools(ScenarioDifficulty difficulty)
		{
			return null;
		}

		public bool FindRewardById(int id, ref Reward reward)
		{
			return false;
		}

		public Reward[] GetRewards(RewardRate[] rewardRates)
		{
			return null;
		}

		private int ComparePool(Pool a, Pool b)
		{
			return 0;
		}

		private int CompareReward(Reward a, Reward b)
		{
			return 0;
		}
	}
}
