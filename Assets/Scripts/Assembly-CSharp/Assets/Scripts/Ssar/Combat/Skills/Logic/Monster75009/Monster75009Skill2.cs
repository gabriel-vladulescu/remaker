using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Utils;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75009
{
	public class Monster75009Skill2 : DefaultRangerSkill
	{
		private enum Phase
		{
			First = 0,
			Second = 1
		}

		public class Info
		{
			[Serializable]
			public class Phase1
			{
				public List<ShotConfig> shots;

				public Vector2 center;

				public Vector2 size;
			}

			[Serializable]
			public class Phase2
			{
				public float delayFrame;

				public float interval;

				public List<TrajectoryConfig> trajectories;

				public TrajectoryConfig GetTrajectoryConfig(int count)
				{
					return null;
				}
			}

			[Serializable]
			public class ShotConfig
			{
				public float startFrame;

				public Vector2 startPos;

				public float speed;
			}

			[Serializable]
			public class TrajectoryConfig
			{
				public float speed;

				public Direction direction;

				public float initAngle;

				public float angularSpeed;
			}

			public Phase1 phase1;

			public Phase2 phase2;
		}

		private class CurveTrajectory : Projectile.Trajectory
		{
			private Dependencies dependencies;

			private Character target;

			private float speed;

			private Direction turnDirection;

			private float angularSpeed;

			private Direction casterDirection;

			private Vector3 offset;

			private Vector3 lastTargetPosition;

			private ParticleRotation particleRotation;

			private Vector3 curVelocity;

			private Vector3 initVelocity;

			private const float ANGLE_THRESHOLD = 1f;

			private readonly Vector3 defaultTargetPosition;

			public CurveTrajectory(Dependencies dependencies, Character target, Vector3 startPos, float speed, Direction turnDirection, float angle, float angularSpeed, Vector3 casterPos, Direction casterDirection, Vector3 offset)
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

			private Vector3 TargetBodypartPosition(Character target)
			{
				return default(Vector3);
			}
		}

		private Dependencies dependencies;

		private Info info;

		private EventFrame projectilePhase1Frame;

		private EventFrame projectilePhase2Frame;

		private EventFrame vfxFrame;

		private EventFrame vfxBreakFrame;

		private Queue<GameObject> setupPositions;

		private Dictionary<EventFrame, Vector2> mappingVfxPositions;

		private Phase phase;

		private int curveIndex;

		private int shotSetupCount;

		private float interval;

		public Monster75009Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		protected override bool ShouldPlayBeHitVfx()
		{
			return false;
		}

		private void SpawnPhase1()
		{
		}

		private void SpawnPhase1Shot(int index)
		{
		}

		private CurveTrajectory GetTrajectory(Projectile projectile)
		{
			return null;
		}
	}
}
