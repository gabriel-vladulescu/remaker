using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public abstract class Damage
	{
		private readonly ProjectileType projectileType;

		private readonly int projectileCount;

		private readonly bool shouldTriggerOnHitTarget;

		private readonly bool shouldTriggerOnHitTargetWithFirstHitOnly;

		private readonly bool isWindbox;

		private readonly float damageMultiplier;

		private float timeToLive;

		private readonly float delayHandleObstacleCollision;

		private readonly float delayHandleObjectCollision;

		private readonly HitboxParams hitboxParams;

		private readonly HitboxPositionParams hitboxPositionParams;

		private readonly HitboxModifiers hitboxModifiers;

		private readonly ProjectileTrajectoryParams trajectoryParams;

		public float DamageMultiplier => 0f;

		public bool ShouldTriggerOnHitTarget => false;

		public bool ShouldTriggerOnHitTargetWithFirstHitOnly => false;

		public float DelayHandleObstacleCollision => 0f;

		public float DelayHandleObjectCollision => 0f;

		public HitboxParams HitboxParams => null;

		public HitboxPositionParams HitboxPositionParams => null;

		public HitboxModifiers HitboxModifiers => null;

		public ProjectileTrajectoryParams TrajectoryParams => null;

		public bool IsWindbox => false;

		public Damage(ProjectileType projectileType, int projectileCount, bool shouldTriggerOnHitTarget, bool shouldTriggerOnHitTargetWithFirstHitOnly, bool isWindbox, float damageMultiplier, float timeToLive, HitboxParams hitboxParams, HitboxPositionParams hitboxPositionParams, float delayHandleObstacleCollision, float delayHandleObjectCollision, HitboxModifiers hitboxModifiers, ProjectileTrajectoryParams trajectoryParams)
		{
		}

		public ProjectileType ProjectileType()
		{
			return default(ProjectileType);
		}

		public int ProjectileCount()
		{
			return 0;
		}

		public float TimeToLive()
		{
			return 0f;
		}

		public int MaxEnemyHitCount()
		{
			return 0;
		}

		public void SetTimeToLive(float time)
		{
		}

		public Vector2 GetSpawnPosition()
		{
			return default(Vector2);
		}

		public void SetSpawnPosition(Vector2 position)
		{
		}

		public CoordinateOrigin GetSpawnAnchor()
		{
			return default(CoordinateOrigin);
		}

		public void SetSpawnAnchor(CoordinateOrigin anchor)
		{
		}

		public bool IsSpawnPositionLockedByFacingDirection()
		{
			return false;
		}
	}
}
