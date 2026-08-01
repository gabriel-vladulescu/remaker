using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000001
{
	public class Monster2000001Skill2 : DefaultRangerSkill
	{
		public class Monster2000001Skill2Info
		{
			[Serializable]
			public class Trajectory
			{
				public float jumpHeight;

				public float jumpDurationReachMaxHeight;

				public float jumpDistance;

				public float jumpDurationLandGround;

				public float floatingDuration;
			}

			[Serializable]
			public class SpawnWaveConfig
			{
				public float delayStart;

				public int normalProjectileIndex;

				public int bloodProjectileIndex;

				public DirectionMode directionMode;

				public bool applyDirectionForWholeWave;

				public int maxWave;

				public float waveInterval;

				public int normalProjectileCount;

				public int bloodProjectileCount;

				public OverrideTrajectory overrideTrajectory;

				public TrajectoryOrder trajectoryOrder;

				public TrajectoryPool trajectoryPool;

				public bool applyTrajectoryForWholeWave;

				public string trajectoryList;

				public Vector2 spawnCenterPos;

				public Vector2 spawnAreaSize;

				public SpawnMode spawnMode;

				public float spawnInterval;

				public float bloodPositionY;

				public float distanceAmplitude;

				public int distanceDensity;

				public bool IsOverrideTrajectory => false;

				public int ProjectileCount => 0;

				public List<bool> GetProjectileList()
				{
					return null;
				}

				public List<int> GetTrajectoryIndexes()
				{
					return null;
				}
			}

			public enum DirectionMode
			{
				Random = 0,
				AutoFlip = 1,
				PingPong = 2,
				TrackTarget = 3
			}

			public enum OverrideTrajectory
			{
				None = 0,
				Random = 1,
				SequentialRewind = 2,
				SequentialPingPong = 3
			}

			public enum TrajectoryPool
			{
				All = 0,
				InList = 1
			}

			public enum TrajectoryOrder
			{
				Random = 0,
				Forward = 1,
				Backward = 2
			}

			public enum SpawnMode
			{
				Instant = 0,
				OneByOne = 1
			}

			public List<Trajectory> trajectory;

			public List<SpawnWaveConfig> spawnWaveConfigs;
		}

		private class CurveTrajectory : Projectile.Trajectory
		{
			private JumpGravityControl gravityControl;

			private Vector3 velocity;

			public CurveTrajectory(Monster2000001Skill2Info.Trajectory trajectory, Direction direction, float amplitude, int density)
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
		}

		private class CustomMelee : DefaultMeleeSkill
		{
			private Monster2000001Skill2 mainSkill;

			public CustomMelee(Monster2000001Skill2 mainSkill, Dependencies dependencies)
				: base(null)
			{
			}

			protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
			{
			}

			protected override void OnProjectileFinishEvent(Projectile projectile)
			{
			}
		}

		private Monster2000001Skill2Info info;

		private List<EventFrame> projectileEventFrame;

		private EventFrame meleeEventFrame;

		private List<EventFrame> meleeVfxEventFrame;

		private EventFrame meleeVfxBreakEventFrame;

		private float intervalTime;

		private float waveCount;

		private int waveProjectileCount;

		private int currentTrajectoryIndex;

		private int currentTrajectoryStep;

		private int directionChangeCount;

		private Direction currentDirection;

		private int currentWaveConfigIndex;

		private Monster2000001Skill2Info.SpawnWaveConfig currentWaveConfig;

		private List<Monster2000001Skill2Info.Trajectory> trajectoryList;

		private List<int> originalTrajectoryIndexList;

		private List<int> trajectoryIndexList;

		private readonly CustomMelee meleeSkill;

		private readonly float scaleTime;

		private float originScaleTime;

		private Dictionary<EventFrame, KeyValuePair<EventFrame, Vector2>> mappingVfxPositons;

		private Dictionary<EventFrame, GameObject> mappingMeleeProjectileAndVfx;

		private List<EventFrame> bloodProjectileFlags;

		public Monster2000001Skill2(Dependencies dependencies)
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

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		private void SpawnProjectileWave()
		{
		}

		private EventFrame SpawnMelee(Vector2 pos)
		{
			return null;
		}

		private List<EventFrame> SpawnMeleeVfx()
		{
			return null;
		}

		private void DespawnMeleeVfx(EventFrame meleeFrame)
		{
		}

		private void GetNextWaveConfig()
		{
		}

		private EventFrame GetProjectileFrame(bool isBlood)
		{
			return null;
		}

		private List<Monster2000001Skill2Info.Trajectory> GetTrajectoryPool()
		{
			return null;
		}

		private CurveTrajectory GetTrajectory()
		{
			return null;
		}

		private Direction GetProjectileDirection()
		{
			return default(Direction);
		}

		private Direction GetRandomDirection()
		{
			return default(Direction);
		}

		private Vector2 GetSpawnPosition()
		{
			return default(Vector2);
		}
	}
}
