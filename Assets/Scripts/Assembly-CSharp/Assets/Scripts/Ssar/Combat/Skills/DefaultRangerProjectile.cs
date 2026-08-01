using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultRangerProjectile : Projectile
	{
		public interface LifeCycle
		{
			bool End();
		}

		private class TimeToLiveLifeCycle : LifeCycle
		{
			private DefaultRangerProjectile drp;

			private float timeToLive;

			public TimeToLiveLifeCycle(DefaultRangerProjectile drp, float timeToLive)
			{
			}

			public bool End()
			{
				return false;
			}
		}

		public enum DestroyVfxPositioning
		{
			AtProjectileCenter = 0,
			AtCollisionPosition = 1
		}

		public const int ZERO_DAMAGE_RADIUS = 0;

		private Character caster;

		private Skill skill;

		private readonly Assets.Scripts.Core.Skills.Collision collision;

		private Entity entity;

		private Assets.Scripts.Core.Skills.Collider collider;

		private Vector2 velocity;

		private float timeToLive;

		private bool destroyInCenter;

		private bool dontDestroyOnObstacleHit;

		private GameObject destroyVfxPrefab;

		private GameObject impactVfxPrefab;

		private EffectPool effectPool;

		private readonly float damageRadius;

		private DestroyVfxPositioning dvp;

		private Trajectory trajectory;

		private bool flipImpact;

		private CharacterMediatorComponent characterMediatorComponent;

		private float elapsed;

		private Vector3 pos;

		private MeleeProjectile.HitIntervalAndHitCountFilter filter;

		private Assets.Scripts.Core.Skills.Collider damageRadiusCollider;

		private LifeCycle lifeCycle;

		private Vector2 flyDirectionFromLastUpdate;

		public DefaultRangerProjectile(Character caster, Entity entity, Skill skill, Assets.Scripts.Core.Skills.Collision collision, Assets.Scripts.Core.Skills.Collider collider, Vector2 velocity, float ttl, GameObject destroyVfxPrefab, GameObject impactVfxPrefab, ProjectileTargetFilterParams targetFilterParams, float delayHandleObstacleCollision, float delayHandleObjectCollision, EffectPool effectPool, bool destroyInCenter, bool dontDestroyOnObstacleHit, float damageRadius = -1f, DestroyVfxPositioning dvp = DestroyVfxPositioning.AtCollisionPosition)
			: base(null, null, null, null, 0f, 0f)
		{
		}

		public bool DontDestroyOnObstacleHit()
		{
			return false;
		}

		public void SetDestroyVfxPositioning(DestroyVfxPositioning dvp)
		{
		}

		protected internal override Assets.Scripts.Core.Skills.Collider GetCollider()
		{
			return null;
		}

		protected override List<Character> FindAdditionalCollidedCharacters()
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

		public void AlterLifeCycle(LifeCycle newLifeCycle)
		{
		}

		protected float ElapsedTime()
		{
			return 0f;
		}

		private void PlayDestroyVfx()
		{
		}

		public void PlayImpactVfx(Vector3 atPosition)
		{
		}

		public GameObject GameObject()
		{
			return null;
		}
	}
}
