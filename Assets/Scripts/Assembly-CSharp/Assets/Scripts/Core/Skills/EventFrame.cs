using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class EventFrame
	{
		private EventType type;

		private float frame;

		private Damage damage;

		private Vfx vfx;

		private Sfx sfx;

		private SkillMaterial skillMaterial;

		private SpawnMonster spawnMonster;

		private Move move;

		private Jump jump;

		private MoveTowardDirection moveTowardDirection;

		private Teleport teleport;

		private DisableCollider disableCollider;

		private CameraFx cameraFx;

		private Buff buff;

		private CornerJump cornerJump;

		private MoveUsingSpeed moveUsingSpeed;

		private FlyUpward flyUpward;

		private Drag drag;

		private VfxFollowBone vfxFollowBone;

		private SfxRandomly sfxRandomly;

		private ForceStopMove forceStopMove;

		private PlayAnimation playAnimation;

		private Suicide suicide;

		private object[] extras;

		public Damage Damage => null;

		public Vfx Vfx => null;

		public Sfx Sfx => null;

		public SkillMaterial SkillMaterial => null;

		public SpawnMonster SpawnMonster => null;

		public Move Move => null;

		public Jump Jump => null;

		public MoveTowardDirection MoveTowardDirection => null;

		public Teleport Teleport => null;

		public DisableCollider DisableCollider => null;

		public CameraFx CameraFx => null;

		public Buff Buff => null;

		public CornerJump CornerJump => null;

		public MoveUsingSpeed MoveUsingSpeed => null;

		public FlyUpward FlyUpward => null;

		public Drag Drag => null;

		public object[] Extras => null;

		public VfxFollowBone VfxFollowBone => null;

		public SfxRandomly SfxRandomly => null;

		public ForceStopMove ForceStopMove => null;

		public PlayAnimation PlayAnimation => null;

		public Suicide Suicide => null;

		public static EventFrame OfDamageWithMeleeProjectile(float frame, ProjectileType projectileType, bool shouldTriggerOnHitTarget, bool shouldTriggerOnHitTargetWithFirstHitOnly, bool isWindbox, float damageMultiplier, float timeToLive, HitboxParams hitboxParams, HitboxPositionParams hitboxPositionParams, Vector2 meleeDimension, float meleeRotation, float hitboxRadius, int meleeNumberOfHit, float meleeIntervalBetweenHit, string[] meleeIgnoreWhileSkillIdsAreUsing, GameObject meleeNotificationVfxPrefab, GameObject meleeImpactVfxPrefab, float delayHandleObstacleCollision, float delayHandleObjectCollision, HitboxModifiers hitboxModifiers, ProjectileTrajectoryParams trajectoryParams, float ignoreDefChance, bool meleeIgnoreHeroPosOnYAxis, bool standstillAfterCreation, bool showTrueGizmo)
		{
			return null;
		}

		public static EventFrame CloneFromOtherDamageWithMeleeProjectile(EventFrame other)
		{
			return null;
		}

		public static EventFrame OfDamageWithRangerProjectile(float frame, ProjectileType projectileType, bool shouldTriggerOnHitTarget, bool shouldTriggerOnHitTargetWithFirstHitOnly, bool isWindbox, float damageMultiplier, float timeToLive, HitboxParams hitboxParams, HitboxPositionParams hitboxPositionParams, GameObject rangerProjectilePrefab, int rangerProjectileDirectionSpread, Vector2 rangerProjectileVelocity, Vector2 rangerProjectileRay1, Vector2 rangerProjectileRay2, int rangerProjectileRayCount, float rangerProjectileHitboxRadius, float rangerProjectileDamageRadius, bool destroyInCenterProjectile, bool dontDestroyOnObstacleHit, bool findTargetInFront, GameObject rangerProjectileDestroyVfxPrefab, GameObject rangerProjectileImpactVfxPrefab, float projectileCastingDelay, GameObject vfxPrefab, CoordinateOrigin coordinateOrigin, int xAxisDensity, float xAxisAmplitude, int yAxisDensity, float yAxisAmplitude, Vector2 meleeDimension, int meleeNumberOfHit, float meleeIntervalBetweenHit, float delayHandleObstacleCollision, float delayHandleObjectCollision, HitboxModifiers hitboxModifiers, float speed, float angleStep, int spreadCount, float maxAngleFromDownVector, float waitTimeFromLockToLaunch, float penetrateProjectileDamageReductionMultiplier, bool showTrueGizmo, HitboxLockTargetParams lockTargetParams, ProjectileTrajectoryParams trajectoryParams)
		{
			return null;
		}

		public static EventFrame CloneFromOtherDamageWithRangerProjectile(EventFrame other)
		{
			return null;
		}

		private static HitboxParams CloneFromOtherHitboxParams(HitboxParams other)
		{
			return null;
		}

		private static HitboxPositionParams CloneFromOtherHitboxPositionParams(HitboxPositionParams other)
		{
			return null;
		}

		private static HitboxModifiers CloneFromOtherHitboxModifiers(HitboxModifiers other)
		{
			return null;
		}

		private static HitboxLockTargetParams CloneFromOtherHitboxLockTargetParams(HitboxLockTargetParams other)
		{
			return null;
		}

		private static ProjectileTrajectoryParams CloneFromOtherProjectileTrajectoryParams(ProjectileTrajectoryParams other)
		{
			return null;
		}

		public static EventFrame OfVfx(float frame, GameObject[] vfxPrefabs, bool followCasterPosition, bool ignoreCasterPosOnYAxis, bool ignoreCasterDirection, CoordinateOrigin coordinateOrigin, Vector2 offset)
		{
			return null;
		}

		public static EventFrame CloneFromOtherVfx(EventFrame other)
		{
			return null;
		}

		public static EventFrame CloneFromOtherVfxEventFrame(EventFrame vfxEventFrame)
		{
			return null;
		}

		public static EventFrame OfSfx(float frame, string path, float speed)
		{
			return null;
		}

		public static EventFrame OfMaterial(float frame, Material material, string objectName, float endFrame)
		{
			return null;
		}

		public static EventFrame OfSpawnMonster(float frame, string id, int count, float interval, float xAxisAmplitude, int xAxisDensity, float yAxisAmplitude, int yAxisDensity, Vector2 offsetPosition, CoordinateOrigin coordinateOrigin, float padding, int onSpawnMovementType, float onSpawnJumpDurationReachMaxHeight, float onSpawnJumpDurationLandGround, float onSpawnJumpHeight, GameObject minionVfxPrefab, float spawnDelay, float suicideAfterSeconds)
		{
			return null;
		}

		public static EventFrame OfMove(float frame, float distance, float endFrame, float blendTime, bool adjustCollider, Vector2 moveColliderCenter, Vector2 moveColliderSize, string extras, bool isFromUserInput = false, bool moveBackward = false, bool moveTowardTarget = false, AnimationCurve curve = null, float maxSpeed = 0f, bool ignoreMoveDirection = false)
		{
			return null;
		}

		public static EventFrame OfJump(float frame, int count, float height, float durationReachMaxHeight, float distance, float durationLandGround, bool isFromSignatureSkill, bool disableOnGround, float floatingDuration = 0f, bool jumpBackward = false)
		{
			return null;
		}

		public static EventFrame OfMoveTowardTarget(float frame, float[] speed, float[] duration, float[] distance, bool moveUntilReachTarget, bool moveUntilReachBySpeed, bool ignoreTargetY, string animationName, string skipAnimationName)
		{
			return null;
		}

		public static EventFrame OfTeleport(float frame, TeleportMode mode, TeleportSide side, float notificationFrame, GameObject notificationPrefab, Vector2 relativePosition, float frameToTrackTargetPosition, float padding, bool isIgnoreTargetY, float minDistanceToTarget, float maxDistanceToTarget, float offsetY, bool looAtTarget, float appearAtFrame)
		{
			return null;
		}

		public static EventFrame CloneFromOtherTeleport(EventFrame other)
		{
			return null;
		}

		public static EventFrame OfDisableCollider(float frame, float endFrame)
		{
			return null;
		}

		public static EventFrame OfCameraFx(float frame, CameraFx cf)
		{
			return null;
		}

		public static EventFrame OfBuff(float frame, Buff buff)
		{
			return null;
		}

		public static EventFrame CloneFromOtherBuff(EventFrame other)
		{
			return null;
		}

		public static EventFrame OfCornerJump(float frame, List<CornerJumpElement> jumpByDistance, string skillNumber)
		{
			return null;
		}

		public static EventFrame OfMoveUsingSpeed(float frame, string animationName, bool changeFacingDirection, float acceleration, float startSpeed, float maxSpeed, float distance, float delayMove)
		{
			return null;
		}

		public static EventFrame OfFlyUpward(float frame, float speed)
		{
			return null;
		}

		public static EventFrame OfDrag(float frame, float duration, float radius, Vector2 offset)
		{
			return null;
		}

		public static EventFrame OfVfxFollowBone(float frame, GameObject prefab, float timeToLiveInSeconds, string[] boneNames)
		{
			return null;
		}

		public static EventFrame CloneFromOtherVfxFollowBone(EventFrame other)
		{
			return null;
		}

		public static EventFrame OfSfxRandomly(float frame, string[] paths, float speed, string extras)
		{
			return null;
		}

		public static EventFrame OfForceStopMove(float frame, float durationInSeconds)
		{
			return null;
		}

		public static EventFrame OfPlayAnimation(float frame, string animationName)
		{
			return null;
		}

		public static EventFrame OfSuicide(float frame, float deathDuration)
		{
			return null;
		}

		private EventFrame(EventType type, float frame)
		{
		}

		public EventType Type()
		{
			return default(EventType);
		}

		public float Frame()
		{
			return 0f;
		}

		public void SetFrame(float frame)
		{
		}

		public void ReduceFrameBy(float value)
		{
		}

		public void SetExtras(object[] extras)
		{
		}
	}
}
