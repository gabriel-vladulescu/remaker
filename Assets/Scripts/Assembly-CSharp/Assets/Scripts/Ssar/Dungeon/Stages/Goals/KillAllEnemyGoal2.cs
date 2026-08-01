using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Goals
{
	public class KillAllEnemyGoal2 : Goal
	{
		private readonly Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private DefaultStage stage;

		private float interval;

		private float elapsed;

		private bool achieved;

		public KillAllEnemyGoal2(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
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
