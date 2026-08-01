using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.LosingConditions
{
	public class CountdownTimerLosingCondition : LosingCondition
	{
		private float seconds;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private float lastTime;

		private bool lastTimeInited;

		private NotNullReference notNullReference;

		public CountdownTimerLosingCondition(float seconds, Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public CountdownTimerLosingCondition(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public bool IsMet()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
