using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Utils;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000001
{
	public class Monster2000001Skill8 : DefaultRangerSkill
	{
		public class Info
		{
			public int launchingIntervalInFrames;

			public int projectileCount;

			public float speed;

			public float maxSteeringForce;

			public float mass;

			public float angleThreshold;

			public float angularSpeed;

			public float initAngle;

			public float openAngle;

			public float minAngle;

			public ChaseMode chaseMode;

			public float seekMinDistance;

			public bool isRecordPath;

			public float pathInterval;

			public bool isAutoClearBloodOnFinish;
		}

		public enum ChaseMode
		{
			SingleCurve = 0,
			Free = 1
		}

		private class BloodLink : Projectile.Trajectory
		{
			private List<Vector3> path;

			private float interval;

			private float elaspedFromLastNode;

			private bool isRecordPath;

			public BloodLink(float interval, bool isRecordPath)
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

			public virtual void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}

			public Vector3[] GetPath()
			{
				return null;
			}
		}

		private class BloodLinkChaser : BloodLink
		{
			private Character target;

			private CachingComponent cachingComponent;

			private float maxSpeed;

			private float maxForce;

			private float mass;

			private float angleThreshold;

			private Direction turnDirection;

			private float angularSpeed;

			private Direction facingDirection;

			private Vector3 offset;

			private ChaseMode chaseMode;

			private float minDistanceToSeek;

			private Vector3 lastTargetPosition;

			private Vector3 curVelocity;

			private ParticleRotation particleRotation;

			private const float ANGLE_THRESHOLD = 1f;

			public BloodLinkChaser(Character target, CachingComponent cachingComponent, float maxSpeed, float maxForce, float mass, float angleThreshold, Direction turnDirection, float angularSpeed, Direction facingDirection, Vector3 offset, Vector3 initVelocity, Vector3 casterPos, ChaseMode chaseMode, float minDistanceToSeek, bool isRecordPath, float pathInterval)
				: base(pathInterval, isRecordPath)
			{
			}

			public override void Update(float dt, Projectile projectile, Vector3 currentPosition)
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

		private Info info;

		private EventFrame damageEventFrame;

		private List<EventFrame> vfxBoneEventFrames;

		private FrameAndSecondsConverter frameConverter;

		private BloodLink currentBloodLink;

		private Projectile currentProjectile;

		private Dictionary<Projectile, Character> projectilesAndCharacters;

		private List<Projectile> triggeredProjectiles;

		private List<Character> triggeredCharacters;

		private bool isBloodLinkTriggerd;

		private Dictionary<EventFrame, List<GameObject>> mappingEventFrameAndVfx;

		public Monster2000001Skill8(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override bool UseCharacterFacingDirectionForCalculatingProjectileSpawnPosition()
		{
			return false;
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override Vector3[] GetProjectilePath()
		{
			return null;
		}

		protected override object[] GetProjectileCookies()
		{
			return null;
		}

		public override void OnFinish(Character character)
		{
		}

		protected override void OnVfxFollowBonePlayed(EventFrame ef, List<GameObject> vfxs)
		{
		}

		private void SetTrajectory(Projectile projectile)
		{
		}

		private float GetAngle(CachingComponent target, Vector3 projectilePos, Direction facingDirection, ref bool isHighAngle)
		{
			return 0f;
		}

		private Vector3 GetProjectileDirection(float angle, Direction facingDirection)
		{
			return default(Vector3);
		}

		private BloodBondModifier GetCharacterBloodBonded(Character character)
		{
			return null;
		}

		private void SpawnVfxBone()
		{
		}
	}
}
