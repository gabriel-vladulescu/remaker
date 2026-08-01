using Scripts.Config;

namespace Ssar.RaidBoss.Battle
{
	public class RaidDropRewardLogic
	{
		private RaidDifficulty curDifficulty;

		private readonly float heroPower;

		private bool isUseHeroPower;

		private readonly double maxGlobalScale;

		private double globalScale;

		public RaidDropRewardLogic(MainCharacterData mainCharacterData, RaidDifficulty difficulty)
		{
		}

		public RaidBossConfig.BattleReward[] DropRewards(int rank, RaidBossConfig.BattleReward[] rewardPool)
		{
			return null;
		}

		public RaidBossConfig.BattleReward[] GenerateGlobalRewards(RaidBossConfig.GlobalReward globalReward)
		{
			return null;
		}

		private RaidBossConfig.BattleReward[] GenerateRewardsByType(RaidBossConfig.BattleReward[] rewardPool, int[] range)
		{
			return null;
		}

		private RaidBossConfig.BattleReward[] ConvertRewardsByHeroPower(RaidBossConfig.BattleReward[] rewards, double scaleQuantity)
		{
			return null;
		}

		private int ConvertQuantity(RaidBossConfig.BattleReward reward, double scaleQuantity, double globalScale)
		{
			return 0;
		}
	}
}
