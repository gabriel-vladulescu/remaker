using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;

namespace Assets.Scripts.Ssar.Dungeon.StageActivators
{
	public class ChallengeLevelUpStageActivator : StageActivator
	{
		private float duration;

		private float elasped;

		private bool actived;

		private Action callback;

		public ChallengeLevelUpStageActivator(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
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

		private void OnBuffSelected()
		{
		}
	}
}
