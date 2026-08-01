using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Goals
{
	public class KillAllEnemyGoal : Goal
	{
		private int enemyCount;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private List<Monster> recognizedDeadMonster;

		private float lastTimeCheck;

		private bool lastTimeCheckInited;

		private NotNullReference notNullReference;

		public KillAllEnemyGoal(int enemyCount, Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public KillAllEnemyGoal(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
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
