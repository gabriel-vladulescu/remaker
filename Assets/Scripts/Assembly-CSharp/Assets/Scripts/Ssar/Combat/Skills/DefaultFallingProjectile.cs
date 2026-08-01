using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultFallingProjectile : Projectile
	{
		private readonly Skill skill;

		private readonly Assets.Scripts.Core.Skills.Collider collider;

		private readonly Entity entity;

		private readonly GameObject destroyVfxPrefab;

		private readonly float gravity;

		private EffectPool effectPool;

		private bool destroyed;

		private Vector3 velocity;

		private Vector3 a;

		private CharacterMediatorComponent characterMediatorComponent;

		public DefaultFallingProjectile(Skill skill, Assets.Scripts.Core.Skills.Collision collision, Assets.Scripts.Core.Skills.Collider collider, ProjectileTargetFilterParams targetFilterParams, Character caster, Entity entity, GameObject destroyVfxPrefab, float gravity, EffectPool effectPool)
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

		private void PlayDestroyVfx()
		{
		}
	}
}
