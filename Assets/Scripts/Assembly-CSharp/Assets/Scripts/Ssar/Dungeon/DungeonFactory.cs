using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Stages;
using Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon
{
	public class DungeonFactory
	{
		private DungeonConfig dungeonConfig;

		private DefaultEnvironment defaultEnvironment;

		private NotNullReference notNullReference;

		public DungeonFactory(DungeonConfig dungeonConfig, DefaultEnvironment defaultEnvironment)
		{
		}

		public Dungeon CreateDungeon(int dungeonId)
		{
			return null;
		}

		private void CreateStageActivators(Assets.Scripts.Ssar.Dungeon.Configs.Dungeon dungeonCfg, Dungeon dungeon)
		{
		}

		private void CreateGates(Assets.Scripts.Ssar.Dungeon.Configs.Dungeon dungeonCfg, Dungeon dungeon)
		{
		}

		private void CreateStages(Assets.Scripts.Ssar.Dungeon.Configs.Dungeon dungeonCfg, Dungeon dungeon)
		{
		}

		private void CreateChallenges(Stage stageConfig, DefaultStage stage)
		{
		}

		private Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers.Trigger CreateTrigger(Assets.Scripts.Ssar.Dungeon.Configs.Trigger triggerConfig)
		{
			return null;
		}

		private void CreateLosingConditions(Stage stageConfig, DefaultStage stage)
		{
		}

		private void CreateGoals(Stage stageConfig, DefaultStage stage)
		{
		}
	}
}
