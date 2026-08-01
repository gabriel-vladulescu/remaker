using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultBoomerangProjectile : Projectile
	{
		private readonly Skill skill;

		private readonly Assets.Scripts.Core.Skills.Collider collider;

		private readonly float ttl;

		private readonly Entity entity;

		private readonly GameObject destroyVfxPrefab;

		private readonly GameObject impactVfxPrefab;

		private readonly Vector2 initialVelocity;

		private EffectPool effectPool;

		private float elapsed;

		private Vector2 velocity;

		private CharacterMediatorComponent characterMediatorComponent;

		private Dictionary<Character, int> charactersAndHitCount;

		private Dictionary<Character, float> charactersAndHitTime;

		private bool isReturnedToThrower;

		private float lastEasingValue;

		private Vector2 offsetWithCaster;

		public DefaultBoomerangProjectile(Skill skill, Assets.Scripts.Core.Skills.Collision collision, Assets.Scripts.Core.Skills.Collider collider, ProjectileTargetFilterParams targetFilterParams, float ttl, Entity entity, GameObject destroyVfxPrefab, GameObject impactVfxPrefab, Vector2 initialVelocity, EffectPool effectPool, float delayHandleObjectCollision)
			: base(null, null, null, null, 0f, 0f)
		{
		}

		protected internal override Assets.Scripts.Core.Skills.Collider GetCollider()
		{
			return null;
		}

		protected internal override List<Character> PickInterestedOnesFrom(List<Character> collidedCharacters)
		{
			return null;
		}

		protected internal override void UpdateTrajectory(float dt)
		{
		}

		private Vector3 CasterPosWithOffset()
		{
			return default(Vector3);
		}

		protected internal override bool IsFinish()
		{
			return false;
		}

		protected override void OnDestroy()
		{
		}

		public override Vector3 Position()
		{
			return default(Vector3);
		}

		public override Vector3 Velocity()
		{
			return default(Vector3);
		}

		public override Quaternion Rotation()
		{
			return default(Quaternion);
		}

		public override void SetVelocity(Vector3 velocity)
		{
		}

		public override void SetPosition(Vector3 newPosition)
		{
		}

		public override void SetTrajectory(Trajectory newTrajectory)
		{
		}

		public override Trajectory GetTrajectory()
		{
			return null;
		}

		public void PlayDestroyVfx()
		{
		}

		public void PlayImpactVfx(Vector3 atPosition)
		{
		}
	}
}
