using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Gizmo;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4200
{
	public class Monster4200Skill4 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public class WaveForm
			{
				public Vector2 size;

				public float height;
			}

			public class WaveInfo
			{
				public float activationTime;

				public float waveStartupDelay;

				public float spawnDelay;

				public CoordinateOrigin coordinateOrigin;

				public StartForm startForm;

				public float speed;
			}

			public enum StartForm
			{
				Random = 0,
				Min = 1,
				Max = 2
			}

			public List<WaveInfo> waveInfos;

			public WaveForm minForm;

			public WaveForm maxForm;

			public float transformationTime;

			public AnimationCurve transformationCurve;

			public bool affectFx;

			public Vector2 projectileBaseSize;

			public float adjustAnimSpdFrom;

			public float adjustAnimSpdTo;

			public float animSpeed;
		}

		private enum State
		{
			Ready = 0,
			Processing = 1,
			Recovery = 2
		}

		private class WaveSource
		{
			public Vector2 position;

			public EventFrame vfxFrame;

			public EventFrame destroyVfxFrame;

			public List<EventFrame> damageFrames;

			public GameObject vfx;

			public float duration;

			public bool IsSourceOfProjectle(Projectile projectile)
			{
				return false;
			}
		}

		private class ResizableTrajectory : Projectile.Trajectory
		{
			private SkillInfo.WaveForm waveFrom;

			private SkillInfo.WaveForm waveTo;

			private Vector2 projectileBaseSize;

			private AnimationCurve curve;

			private float transformationTime;

			private float casterHeight;

			private bool affectFx;

			private float interval;

			public ResizableTrajectory(SkillInfo.WaveForm waveFrom, SkillInfo.WaveForm waveTo, Vector2 projectileBaseSize, AnimationCurve curve, float transformationTime, float casterHeight, bool affectFx)
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

		private SkillInfo info;

		private EventFrame vfxFrame;

		private EventFrame destroyVfxFrame;

		private List<EventFrame> waveStartupVfxFrames;

		private List<EventFrame> damageFrames;

		private List<WaveSource> waveSources;

		private bool isTransformForward;

		private int waveCount;

		private State adjustAnimSpdState;

		private float originalAnimSpeed;

		public Monster4200Skill4(Dependencies dependencies)
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

		protected override bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected override void OnUpdateGizmoDrawRequest(Projectile projectile, GizmoDrawRequest drawRequest)
		{
		}

		public override void Interrupt()
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

		protected override bool ShouldPlayBeHitVfx()
		{
			return false;
		}

		public override DamageSource GetDamageSource()
		{
			return default(DamageSource);
		}

		private SkillInfo.WaveInfo GetWaveInfo(int count)
		{
			return null;
		}

		private void SpawnWaveSource(SkillInfo.WaveInfo waveInfo)
		{
		}
	}
}
