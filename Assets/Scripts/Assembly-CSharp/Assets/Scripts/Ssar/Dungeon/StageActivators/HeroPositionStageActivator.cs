using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.StageActivators
{
	public class HeroPositionStageActivator : StageActivator
	{
		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private float activationX;

		private bool actived;

		private NotNullReference notNullReference;

		public HeroPositionStageActivator(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
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
