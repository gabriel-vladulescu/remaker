using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class RangerProjectileConfig
	{
		[PreloadPool.PrefabPathMarker]
		public string rangerProjectilePrefabPath;

		public string rangerProjectileDirectionSpread;

		public Vector2 rangerProjectileVelocity;

		public Vector2 rangerProjectileRay1;

		public Vector2 rangerProjectileRay2;

		public int rangerProjectileRayCount;

		public float rangerProjectileHitboxRadius;

		public float rangerProjectileDamageRadius;

		public bool rangerProjectileDrawGizmos;

		public bool destroyInCenterProjectile;

		public bool dontDestroyOnObstacleHit;

		public bool findTargetInFront;

		[PreloadPool.PrefabPathMarker]
		public string rangerProjectileDestroyVfxPrefabPath;

		[PreloadPool.PrefabPathMarker]
		public string rangerProjectileImpactVfxPrefabPath;

		public Vector2 rangerProjectileSpawnPositionRelativeToCharacter;

		public bool rangerProjectileSpawnPositionRelativeToFacingDirection;

		public float projectileCastingDelay;

		[PreloadPool.PrefabPathMarker]
		public string vfxPrefabPath;

		public string coordinateOrigin;

		public int xAxisDensity;

		public float xAxisAmplitude;

		public int yAxisDensity;

		public float yAxisAmplitude;

		public float waitTimeFromLockToLaunch;

		public float penetrateProjectileDamageReductionMultiplier;

		public float speed;

		public float angleStep;

		public int spreadCount;

		public float maxAngleFromDownVector;

		public int waveCount;

		public float waveInterval;

		public bool lockTargetPosition;

		public Vector2 lockTargetOffset;

		public HitboxLockTargetDirection lockTargetDirection;

		public RangerProjectileDirectionSpread RangerProjectileDirectionSpreadValue()
		{
			return default(RangerProjectileDirectionSpread);
		}

		public CoordinateOrigin CoordinateOriginValue()
		{
			return default(CoordinateOrigin);
		}
	}
}
