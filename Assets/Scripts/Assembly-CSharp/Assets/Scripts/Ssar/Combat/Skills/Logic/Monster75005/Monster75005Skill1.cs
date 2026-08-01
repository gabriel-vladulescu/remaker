using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75005
{
	public class Monster75005Skill1 : DefaultRangerSkill
	{
		public Monster75005Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		protected override bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected override Vector2 DirectionTowardNearestTarget(Vector3 pivotPosition, bool ignoreTargetY = false)
		{
			return default(Vector2);
		}

		protected override Vector3 OverrideProjectilePositionForRangerProjectileTowardTarget(EventFrame ef, Vector3 currentPosition)
		{
			return default(Vector3);
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}
	}
}
