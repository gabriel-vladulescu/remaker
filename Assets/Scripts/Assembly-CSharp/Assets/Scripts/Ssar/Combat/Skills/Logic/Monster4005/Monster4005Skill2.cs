using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4005
{
	public class Monster4005Skill2 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public enum SpawnIntervalMode
			{
				Sequential = 0,
				Random = 1
			}

			public float minRange;

			public float maxRange;

			public float activateTime;

			public float spawnInterval;

			public float spawnDelay;

			public int rootCount;

			public string rootVfxPath;

			public float slowFrom;

			public float slowTo;

			public float slowSpeed;

			public SpawnIntervalMode spawnIntervalMode;

			public List<float> spawnIntervals;

			public float spawnIntervalAmplitude;

			public int spawnIntervalDensity;

			public float rootPosAmplitude;

			public int rootPosDensity;

			public float padding;
		}

		private enum State
		{
			Ready = 0,
			Processing = 1,
			Recovery = 2
		}

		private new class StandStillTrajectory : Projectile.Trajectory
		{
			private Vector3 position;

			private bool isPosInitialized;

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

		private class StandStillDragTrajectory : StandStillTrajectory
		{
			private List<Character> targets;

			private Vector3 pivotPos;

			private Vector3 offset;

			private float offsetLength;

			private float dragDuration;

			private const float DEFAULT_DURATION = 0.15f;

			public void AddTarget(Character target, Vector3 pivotPos, Vector3 offset)
			{
			}

			public void RemoveTarget(Character target)
			{
			}

			public void ClearTarget()
			{
			}

			public override void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}
		}

		private SkillInfo info;

		private EventFrame damageFrame;

		private EventFrame vfxFrame;

		private EventFrame startupVfxFrame;

		private EventFrame breakVfxFrame;

		private float interval;

		private int waveIndex;

		private Dictionary<Projectile, Character> hittedProjectiles;

		private Dictionary<EventFrame, Vector3> mappingVfxToPos;

		private List<Projectile> rootedProjectiles;

		private Dictionary<Projectile, StandStillDragTrajectory> trajectories;

		private State slowAnimState;

		private float originalAnimSpeed;

		private bool isRooted;

		public Monster4005Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void OnProjectileFinishEvent(Projectile projectile)
		{
		}

		public override bool IsChannelingFinish()
		{
			return false;
		}

		public override void Interrupt()
		{
		}

		private float GetSpawnInterval()
		{
			return 0f;
		}

		private Vector2 GetTargetRelativePos()
		{
			return default(Vector2);
		}

		private void SpawnRoot()
		{
		}

		private float ClampXByMap(float x)
		{
			return 0f;
		}

		private void SpawnDamage(Vector3 relativePos)
		{
		}

		private void SpawnStartupVfx(Vector3 targetPos)
		{
		}

		private void SpawnVfx(Vector3 targetPos)
		{
		}

		private void SpawnBreakVfx(Vector3 targetPos)
		{
		}
	}
}
