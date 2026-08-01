using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers
{
	public class WaitForSecondsTrigger : Trigger
	{
		private float waitTimeInSeconds;

		private float waitTimeAmplitudeInSeconds;

		private int waitTimeDensity;

		private NotNullReference notNullReference;

		public WaitForSecondsTrigger()
		{
		}

		public WaitForSecondsTrigger(float waitTimeInSeconds)
		{
		}

		public WaitForSecondsTrigger(GameObjectSpawner gameObjectSpawner)
		{
		}

		public void SetEnv(Assets.Scripts.Ssar.Dungeon.Environment.Environment env)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public string UnfinishedReason()
		{
			return null;
		}

		public bool IsFinished()
		{
			return false;
		}

		public void Update(float dt, int waveOrder)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private float Random(float baseValue, float amplitude, int density)
		{
			return 0f;
		}
	}
}
