using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultBoomerangSkill : DefaultRangerSkill
	{
		private EntityWorld entityWorld;

		public DefaultBoomerangSkill(Dependencies dependencies)
			: base(null)
		{
		}

		protected override bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		private void PlayImpactVfx(Projectile projectile, List<Character> hitTargets)
		{
		}
	}
}
