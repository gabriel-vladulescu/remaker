using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	[Serializable]
	public class Character1Skill6Info
	{
		public float knockbackValueFrom;

		public float knockbackValueTo;

		public List<WeaponVfxInfo> weaponVfxInfos;

		public List<ProjectileMovementInfo> projectileMovementInfos;
	}
}
