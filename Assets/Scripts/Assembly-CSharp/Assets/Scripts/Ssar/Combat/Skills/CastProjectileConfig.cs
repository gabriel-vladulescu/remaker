using System;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CastProjectileConfig
	{
		public int projectileOrder;

		public float delay;

		public CoordinateOrigin anchor;
	}
}
