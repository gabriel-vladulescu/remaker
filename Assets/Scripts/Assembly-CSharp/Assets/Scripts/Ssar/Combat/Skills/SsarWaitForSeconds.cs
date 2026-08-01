using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SsarWaitForSeconds
	{
		private readonly float waitTimeInSeconds;

		private readonly Action callback;

		private float elapsed;

		private bool finish;

		public SsarWaitForSeconds(float waitTimeInSeconds, Action callback)
		{
		}

		public void Update(float dt)
		{
		}
	}
}
