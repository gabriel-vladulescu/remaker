using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75011
{
	public class Monster75011Skill2 : DefaultMeleeSkill
	{
		public class Info
		{
			public float activateTime;

			public float interval;

			public int waveCount;

			public float spawnDelay;

			public bool disableSeparateModifier;
		}

		private new class StandStillTrajectory : Projectile.Trajectory
		{
			private readonly Vector3 position;

			private bool firstUpdate;

			public StandStillTrajectory(Vector3 position)
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

		private Info info;

		private List<EventFrame> damageEventFrames;

		private List<EventFrame> vfxEventFrames;

		private List<EventFrame> startupVfxEventFrames;

		private List<EventFrame> breakVfxEventFrames;

		private float interval;

		private int waveIndex;

		private int vfxIndex;

		private List<int> checkedTargetIds;

		private Dictionary<EventFrame, int> mappingDamageFrameIndex;

		private List<Vector3> damagePos;

		private Dictionary<EventFrame, Vector3> mappingVfxToPos;

		public Monster75011Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected virtual void Activate()
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		protected override bool ShouldPlayBeHitVfx(EventFrame eventFrame, Projectile projectile)
		{
			return false;
		}

		protected virtual void Activate(Vector3 targetPos)
		{
		}

		protected void ActivateDamage(Vector3 targetPos, int index)
		{
		}

		protected void ActivateDamage(Vector3 targetPos)
		{
		}

		protected void ActivateVfx(Vector3 targetPos)
		{
		}

		protected void ActivateStartVfx(Vector3 targetPos)
		{
		}

		protected void ActivateBreakVfx(Vector3 targetPos)
		{
		}

		protected Vector3 GetTargetPos()
		{
			return default(Vector3);
		}

		private Character FindTarget()
		{
			return null;
		}

		private EventFrame GetVfx()
		{
			return null;
		}
	}
}
