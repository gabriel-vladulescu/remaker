using Scripts.Config;
using Scripts.Config.Stats;
using UnityEngine;

namespace Ssar.RaidBoss.Battle
{
	public class RaidMonsterStatsLogic
	{
		private EntityAbilities heroAbilities;

		private RaidBossConfig.RaidMonsterLevelStats raidStats;

		private readonly int heroPower;

		private int hitCountToKillHero;

		private int hitCountUntilDie;

		public RaidMonsterStatsLogic(MainCharacterData mainCharacterData)
		{
		}

		public HeroLevelStats GenerateLevelStats(RaidBossConfig.RaidMonsterLevelStats raidMonsterLevelStats)
		{
			return null;
		}

		private int GenerateHitcountToKill()
		{
			return 0;
		}

		private int GenerateHitcountUntilDie()
		{
			return 0;
		}

		private double GenerateAtk()
		{
			return 0.0;
		}

		private double GenerateHP()
		{
			return 0.0;
		}

		private double GenerateDef()
		{
			return 0.0;
		}

		private double GenerateMagicResist()
		{
			return 0.0;
		}

		public Vector2 GetHitcount()
		{
			return default(Vector2);
		}
	}
}
