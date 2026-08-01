using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class RangerDamage : Damage
	{
		private GameObject rangerProjectilePrefab;

		private int rangerProjectileDirectionSpread;

		private Vector2 rangerProjectileVelocity;

		private Vector2 rangerProjectileRay1;

		private Vector2 rangerProjectileRay2;

		private int rangerProjectileRayCount;

		private float rangerProjectileHitboxRadius;

		private float rangerProjectileDamageRadius;

		private bool destroyInCenterProjectile;

		private bool dontDestroyOnObstacleHit;

		private bool findTargetInFront;

		private GameObject rangerProjectileDestroyVfxPrefab;

		private GameObject rangerProjectileImpactVfxPrefab;

		private float projectileCastingDelay;

		private GameObject vfxPrefab;

		private CoordinateOrigin coordinateOrigin;

		private int xAxisDensity;

		private float xAxisAmplitude;

		private int yAxisDensity;

		private float yAxisAmplitude;

		private Vector2 meleeDimension;

		private int meleeNumberOfHit;

		private float meleeIntervalBetweenHit;

		private float speed;

		private float angleStep;

		private int spreadCount;

		private float maxAngleFromDownVector;

		private float waitTimeFromLockToLaunch;

		private float penetrateProjectileDamageReductionMultiplier;

		private readonly bool showTrueGizmo;

		private readonly HitboxLockTargetParams lockTargetParams;

		public bool DestroyInCenterProjectile => false;

		public bool DontDestroyOnObstacleHit => false;

		public bool FindTargetInFront => false;

		public int RangerProjectileDirectionSpread => 0;

		public Vector2 RangerProjectileRay1 => default(Vector2);

		public Vector2 RangerProjectileRay2 => default(Vector2);

		public int RangerProjectileRayCount => 0;

		public float ProjectileCastingDelay => 0f;

		public GameObject VfxPrefab => null;

		public CoordinateOrigin CoordinateOrigin => default(CoordinateOrigin);

		public int XAxisDensity => 0;

		public float XAxisAmplitude => 0f;

		public int YAxisDensity => 0;

		public float YAxisAmplitude => 0f;

		public Vector2 MeleeDimension => default(Vector2);

		public int MeleeNumberOfHit => 0;

		public float MeleeIntervalBetweenHit => 0f;

		public float Speed => 0f;

		public float AngleStep => 0f;

		public int SpreadCount => 0;

		public float MaxAngleFromDownVector => 0f;

		public float WaitTimeFromLockToLaunch => 0f;

		public float PenetrateProjectileDamageReductionMultiplier => 0f;

		public bool ShowTrueGizmo => false;

		public HitboxLockTargetParams LockTargetParams => null;

		public RangerDamage(ProjectileType projectileType, int projectileCount, bool shouldTriggerOnHitTarget, bool shouldTriggerOnHitTargetWithFirstHitOnly, bool isWindbox, float damageMultiplier, float timeToLive, HitboxParams hitboxParams, HitboxPositionParams hitboxPositionParams, GameObject rangerProjectilePrefab, int rangerProjectileDirectionSpread, Vector2 rangerProjectileVelocity, Vector2 rangerProjectileRay1, Vector2 rangerProjectileRay2, int rangerProjectileRayCount, float rangerProjectileHitboxRadius, float rangerProjectileDamageRadius, bool destroyInCenterProjectile, bool dontDestroyOnObstacleHit, bool findTargetInFront, GameObject rangerProjectileDestroyVfxPrefab, GameObject rangerProjectileImpactVfxPrefab, float projectileCastingDelay, GameObject vfxPrefab, CoordinateOrigin coordinateOrigin, int xAxisDensity, float xAxisAmplitude, int yAxisDensity, float yAxisAmplitude, Vector2 meleeDimension, int meleeNumberOfHit, float meleeIntervalBetweenHit, float delayHandleObstacleCollision, float delayHandleObjectCollision, HitboxModifiers hitboxModifiers, float speed, float angleStep, int spreadCount, float maxAngleFromDownVector, float waitTimeFromLockToLaunch, float penetrateProjectileDamageReductionMultiplier, bool showTrueGizmo, HitboxLockTargetParams lockTargetParams, ProjectileTrajectoryParams trajectoryParams)
			: base(default(ProjectileType), 0, shouldTriggerOnHitTarget: false, shouldTriggerOnHitTargetWithFirstHitOnly: false, isWindbox: false, 0f, 0f, null, null, 0f, 0f, null, null)
		{
		}

		public GameObject RangerProjectilePrefab()
		{
			return null;
		}

		public Vector2 RangerProjectileVelocity()
		{
			return default(Vector2);
		}

		public float RangerProjectileHitboxRadius()
		{
			return 0f;
		}

		public float RangerProjectileDamageRadius()
		{
			return 0f;
		}

		public GameObject RangerProjectileDestroyVfxPrefab()
		{
			return null;
		}

		public GameObject RangerProjectileImpactVfxPrefab()
		{
			return null;
		}

		public void SetRangerProjectileVelocity(Vector2 velocity)
		{
		}

		public void SetCoordinateOrigin(CoordinateOrigin coordinateOrigin)
		{
		}
	}
}
