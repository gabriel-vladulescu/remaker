using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;

namespace Assets.Scripts.Ssar.Dungeon.StageActivators
{
	public class ChallengeTimerStageActivator : StageActivator
	{
		private float duration;

		private float elasped;

		private bool actived;

		public ChallengeTimerStageActivator(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}
	}
}
