using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Combo : DefaultRangerSkill
	{
		public Character3Combo(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override bool ShouldPlayBeHitVfx()
		{
			return false;
		}

		protected override bool ShouldPlayImpactVfx()
		{
			return false;
		}
	}
}
