using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Goals
{
	public class KillSpecificTypeOfEnemyGoal : Goal
	{
		private MonsterType monsterType;

		private int killCountRequirement;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private int killCountSoFar;

		private float lastTimeCheck;

		private NotNullReference notNullReference;

		public KillSpecificTypeOfEnemyGoal(MonsterType monsterType, int killCountRequirement, Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public KillSpecificTypeOfEnemyGoal(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public bool IsAchieved()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public void OnAddedToStage(DefaultStage stage)
		{
		}

		public string Reason()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
