using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class PenetrateRangerProjectile : DefaultRangerProjectile
	{
		private MeleeProjectile.MaxEnemyHitCountFilter mehcf;

		private float damageReductionMultiplier;

		public PenetrateRangerProjectile(Character caster, Entity entity, Skill skill, Assets.Scripts.Core.Skills.Collision collision, Assets.Scripts.Core.Skills.Collider collider, Vector2 velocity, float ttl, GameObject destroyVfxPrefab, GameObject impactVfxPrefab, ProjectileTargetFilterParams targetFilterParams, float delayHandleObstacleCollision, float delayHandleObjectCollision, EffectPool effectPool, bool destroyInCenter, bool dontDestroyOnObstacleHit, float damageReductionMultiplier, float damageRadius = -1f)
			: base(null, null, null, null, null, default(Vector2), 0f, null, null, null, 0f, 0f, null, destroyInCenter: false, dontDestroyOnObstacleHit: false, 0f, default(DestroyVfxPositioning))
		{
		}

		protected internal override List<Character> PickInterestedOnesFrom(List<Character> collidedCharacters)
		{
			return null;
		}

		protected internal override bool IsFinish()
		{
			return false;
		}

		protected override bool ShouldFilterMaxEnemyHitCount()
		{
			return false;
		}

		public int NumberOfHit()
		{
			return 0;
		}

		public float DamageReductionMultiplier()
		{
			return 0f;
		}
	}
}
