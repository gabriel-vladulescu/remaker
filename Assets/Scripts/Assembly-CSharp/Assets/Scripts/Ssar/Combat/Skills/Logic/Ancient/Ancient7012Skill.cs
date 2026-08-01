using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Utils;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Ancient
{
	public class Ancient7012Skill : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public float speed;

			public float maxSteeringForce;

			public float mass;

			public float angleThreshold;
		}

		private class Seeker : Projectile.Trajectory
		{
			private Character target;

			private CachingComponent cachingComponent;

			private float maxSpeed;

			private float maxForce;

			private float mass;

			private float angleThreshold;

			private Vector3 lastTargetPosition;

			private Vector3 curVelocity;

			private ParticleRotation particleRotation;

			public Seeker(Character target, CachingComponent cachingComponent, float maxSpeed, float maxForce, float mass, float angleThreshold)
			{
			}

			public Direction AdjustCharacterFacingDirectionParam(Direction currentDirection, Direction directionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Direction);
			}

			public Vector3 AdjustCharacterPositionParam(Vector3 currentCharacterPosition, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Vector3);
			}

			public void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}

			private void UpdateVelocity(float dt, Vector3 direction)
			{
			}

			private Vector3 TargetBodyPosition()
			{
				return default(Vector3);
			}
		}

		private SkillInfo info;

		public Ancient7012Skill(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		private void SetTrajectory(Projectile projectile)
		{
		}
	}
}
