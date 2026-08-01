using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon;
using SSAR.Dungeon.Model;
using Scripts.Config;

namespace Ssar.DailyChallenge.Model
{
	public class ChallengeEndParameters : DungeonWinParameter
	{
		private bool isWin;

		private int roundOrder;

		private int enemiesKilled;

		private ScenarioDifficulty difficulty;

		public bool IsWin => false;

		public int RoundOrder => 0;

		public int EnemiesKilled => 0;

		public ScenarioDifficulty Difficulty => default(ScenarioDifficulty);

		public ChallengeEndParameters(string name, int expBefore, int dungeonId, int expCollected, int expBonus, int soulCollected, int soulBonus, int damageTaken, int battleTime, IDungeonGetStarRule star1 = null, IDungeonGetStarRule star2 = null, IDungeonGetStarRule star3 = null, List<ItemInfo> rewardInfos = null, MemoryShardInfo memoryShardInfo = null)
			: base(null, 0, 0, 0, 0, 0, 0, 0, 0)
		{
		}

		public void SetWin(bool value)
		{
		}

		public void SetRound(int roundOrder)
		{
		}

		public void SetEnemiesKilled(int killed)
		{
		}

		public void SetDifficulty(ScenarioDifficulty difficulty)
		{
		}
	}
}
