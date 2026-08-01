using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.BattleSystem.Damage;
using Scripts.Config;
using Ssar.DailyQuest;

namespace Ssar.Achievement.Metrics
{
	public class MonsterDeathListener
	{
		private AchievementLogic achievementLogic;

		private DamageCalculationSystem damageCalculationSystem;

		private MonsterConfig monsterConfig;

		public MonsterDeathListener(AchievementLogic achievementLogic, DamageCalculationSystem damageCalculationSystem, MonsterConfig monsterConfig, DailyQuestLogic dql, IBattleModeLogic bml)
		{
		}
	}
}
