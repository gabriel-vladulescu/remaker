using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000001
{
	public class Monster2000001Skill1_1 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			[Serializable]
			public class SpawnInfo
			{
				public int projectileIndex;

				public int projectileCount;

				public Vector2 spawnCenter;

				public float spawnRadius;

				public float spawnAngle;

				public float initialAngle;

				public SpawnMode spawnMode;

				public float spawnInterval;

				public LaunchMode launchMode;

				public float delayLaunch;

				public float projectileSpeed;
			}

			public enum SpawnMode
			{
				Clockwise = 1,
				CounterClockwise = -1
			}

			public enum LaunchMode
			{
				Together = 0,
				Independent = 1
			}

			public enum SpawnerPickingMode
			{
				Random = 0,
				RandomInList = 1,
				Sequential = 2
			}

			public float starupTime;

			public int waveCount;

			public float waveInterval;

			public float delaySpawnProjectile;

			public List<SpawnInfo> spawnInfos;

			public SpawnerPickingMode spawnerPickingMode;

			public string spawnerList;

			public float initialAngleAmplitude;

			public int initialAngleDensity;

			public List<int> GetSpawnerList()
			{
				return null;
			}
		}

		public class CustomTrajectory : Projectile.Trajectory
		{
			private float standbyTime;

			private float elapsedTime;

			private Vector3 startPos;

			public CustomTrajectory(float standbyTime)
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
		}

		private SkillInfo info;

		private List<EventFrame> damageEventFrame;

		private EventFrame vfxStartupEventFrame;

		private float intervalWave;

		private int waveCount;

		private SkillInfo.SpawnInfo currentSpawnInfo;

		private int currentSpawnerIndex;

		private List<int> originalSpawnerList;

		private List<int> spawnerList;

		private readonly float scaleTime;

		private float originScaleTime;

		private float randomInitialAngle;

		private List<Vector2> velocities;

		private Dictionary<EventFrame, Vector4> mappingVfxPositions;

		private Dictionary<EventFrame, float> mappingProjectileDelay;

		public Monster2000001Skill1_1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override bool IsChannelingFinish()
		{
			return false;
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		protected override bool UseCharacterFacingDirectionForCalculatingProjectileSpawnPosition()
		{
			return false;
		}

		protected override bool UseCharacterFacingDirectionForCalculatingProjectileVelocity()
		{
			return false;
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected virtual void SetTrajectory(Projectile projectile, float delay)
		{
		}

		protected void SpawnVfx(Vector4 posAndVel, EventFrame source, float frame)
		{
		}

		private List<int> GetSpawnerPool()
		{
			return null;
		}

		private void GetWave()
		{
		}

		private void InitVelocities()
		{
		}

		private void SpawnProjectile(int projectileCount)
		{
		}
	}
}
