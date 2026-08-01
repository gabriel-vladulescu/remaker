using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.AI;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Gizmo;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultRangerSkill : DefaultSkill
	{
		public class ImpactPositions
		{
			protected Projectile projectile;

			protected List<Character> hitTargets;

			protected EntityWorld entityWorld;

			protected Dictionary<int, UnityEngine.Collider> cachedCollidersByCharacterIds;

			protected List<Vector3> positions;

			protected bool shouldRunLogic;

			public ImpactPositions(Projectile projectile, List<Character> hitTargets, EntityWorld entityWorld)
			{
			}

			public virtual List<Vector3> Show()
			{
				return null;
			}
		}

		public class ImpactPosition2
		{
			protected Projectile projectile;

			protected List<Character> hitTargets;

			protected EntityWorld entityWorld;

			protected Dictionary<int, UnityEngine.Collider> cachedCollidersByCharacterIds;

			protected List<Vector3> positions;

			protected bool shouldRunLogic;

			public ImpactPosition2(Projectile projectile, List<Character> hitTargets, EntityWorld entityWorld)
			{
			}

			public List<Vector3> Show()
			{
				return null;
			}
		}

		protected enum CharacterPositionAndFacingDirection
		{
			CastingMoment = 0,
			CurrentMoment = 1
		}

		private SkillData skillData;

		private ProjectileFactory projectileFactory;

		private ProjectileEntityFactory projectileEntityFactory;

		private EntityWorld entityWorld;

		private RoutineRunner routineRunner;

		private Assets.Scripts.Core.Skills.Environment environment;

		private Dictionary<Projectile, List<GizmoDrawRequest>> gizmosDrawRequestByProjectiles;

		private Dictionary<EventFrame, Vector3> launchingPositionForFallingProjectile;

		private List<GameObject> vfxs;

		private Vector3 characterPosAtCasting;

		private Direction characterFacingDirectionAtCasting;

		private List<GameObject> vfxsFollowCasterPosition;

		private List<TimerAction> timerActions;

		private Vector3 lastTargetPosition;

		public DefaultRangerSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected virtual void OnUpdateGizmoDrawRequest(Projectile projectile, GizmoDrawRequest drawRequest)
		{
		}

		protected virtual void PlayAnimation()
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		private void PlayImpactVfx(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		public override void Interrupt()
		{
		}

		protected virtual bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected virtual bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		protected virtual CharacterPositionAndFacingDirection SelectCharacterPositionAndFacingDirection()
		{
			return default(CharacterPositionAndFacingDirection);
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override DamageInfo ConstructDamageInfo(EventFrame eventFrame, int hitTargetId, Projectile projectile)
		{
			return null;
		}

		protected virtual bool ShouldPlayBeHitVfx()
		{
			return false;
		}

		protected virtual bool ShouldPlayImpactVfx()
		{
			return false;
		}

		protected override float AdjustDamageEachTarget(float currentDamage, Projectile projectile, Character hitTarget)
		{
			return 0f;
		}

		private float DamageMultiplierForEachTypeOfProjectile(Projectile p)
		{
			return 0f;
		}

		protected override void PlayVfx(EventFrame ef)
		{
		}

		protected virtual void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		private void WaitThenLaunch(float waitTime, EventFrame ef)
		{
		}

		private new void LaunchProjectiles(EventFrame ef)
		{
		}

		private Vector3 LaunchingPositionForFallingProjectile(EventFrame ef)
		{
			return default(Vector3);
		}

		private void LaunchProjectilesWithMultipleSpread(EventFrame ef)
		{
		}

		private void LaunchProjectilesWith360Spread(EventFrame ef)
		{
		}

		private void LaunchProjectilesWithSingleSpread(EventFrame ef)
		{
		}

		protected virtual Vector3 OverrideProjectilePositionForRangerProjectileTowardTarget(EventFrame ef, Vector3 currentPosition)
		{
			return default(Vector3);
		}

		protected int CharacterFacingDirection()
		{
			return 0;
		}

		protected Vector3 CharacterPosition()
		{
			return default(Vector3);
		}

		protected Vector2 GetProjectileSpawnAnchorPosition(EventFrame eventFrame)
		{
			return default(Vector2);
		}

		private void DelayLaunchProjectile(EventFrame ef, float delayLaunching, Vector3 projectilePosition, Vector2 velocity)
		{
		}

		private void WaitThenInvoke(float waitTime, Action actionToInvoke)
		{
		}

		private Vector2 PickRandomPositionInRectPerimeter(float width, float height, int widthDensity, int heightDensity, Vector2 center)
		{
			return default(Vector2);
		}

		private Vector2 VelocityTowardTargetWithMaxAngleRestriction(Vector3 projectilePosition, RangerDamage rd)
		{
			return default(Vector2);
		}

		private Vector2 GetLockedTargetPosition(RangerDamage rd, int characterFacingDirection)
		{
			return default(Vector2);
		}

		private void OnCreateProjectileSuccess(EventFrame ef, Entity entity, object cookies)
		{
		}

		protected virtual void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected virtual bool UseCharacterFacingDirectionForCalculatingProjectileSpawnPosition()
		{
			return false;
		}

		protected virtual bool UseCharacterFacingDirectionForCalculatingProjectileVelocity()
		{
			return false;
		}

		private bool UseCharacterFacingDirectionForProjectileSpawnPosition(RangerDamage damage)
		{
			return false;
		}

		protected override void OnProjectileFinishEvent(Projectile projectile)
		{
		}

		private void RotateGameObjectFollowingVelocity(Entity entity, Vector2 velocity)
		{
		}

		private float Random(float spawnX, float xAxisAmplitude, int xAxisDensity)
		{
			return 0f;
		}

		protected void ClearGizmosDrawRequests()
		{
		}
	}
}
