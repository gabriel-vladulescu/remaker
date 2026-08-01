using System.Collections.Generic;
using Artemis;

namespace SSAR.Dungeon.Model
{
	public class DungeonObjectiveManager
	{
		public class StageGoal
		{
			public GoalType type;

			public List<string> cookies;

			public int count;

			public int index;

			public StageGoal(int index, string text)
			{
			}

			public bool IsValid(Entity entity)
			{
				return false;
			}

			public int GetRequire()
			{
				return 0;
			}

			public bool IsCompleted()
			{
				return false;
			}
		}

		public enum GoalType
		{
			KillAllEnemy = 0,
			KillAllEnemy2 = 1,
			KillSpecificTypeOfEnemy = 2,
			KillEnemyOfSpecificId = 3
		}

		private List<StageGoal> currentStageGoals;

		private int completed;

		public void UpdateListGoal(string[] goals)
		{
		}

		public void ReUpdateListGoal()
		{
		}

		public void DamageCalculationSystemOnEntityDeathEvent(Entity entity)
		{
		}

		public int GetNumOfObjectiveCompleted()
		{
			return 0;
		}
	}
}
