using Assets.Scripts.Ssar.Dungeon.Environment;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Goals
{
	public class CountDownToZeroGoal : Goal
	{
		private float startNumberOfSecond;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private float lastTime;

		public CountDownToZeroGoal(float startNumberOfSecond, Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
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
	}
}
