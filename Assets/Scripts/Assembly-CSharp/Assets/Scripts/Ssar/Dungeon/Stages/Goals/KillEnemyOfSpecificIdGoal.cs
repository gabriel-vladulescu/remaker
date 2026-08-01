using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Goals
{
	public class KillEnemyOfSpecificIdGoal : Goal
	{
		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private string enemyId;

		private int enemyCount;

		private NotNullReference notNullReference;

		private List<Monster> recognizedDeadMonster;

		private float lastTimeCheck;

		private bool lastTimeCheckInited;

		public KillEnemyOfSpecificIdGoal(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
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

		public void SetCookies(IEnumerable<string> cookies)
		{
		}
	}
}
