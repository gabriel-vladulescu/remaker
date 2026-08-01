using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class TeleportConfig
	{
		public float minDistanceToTarget;

		public float maxDistanceToTarget;

		public float offsetY;

		public bool lookAtTarget;

		public int side;
	}
}
