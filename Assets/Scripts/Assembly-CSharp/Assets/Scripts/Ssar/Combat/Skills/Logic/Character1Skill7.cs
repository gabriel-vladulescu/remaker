using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character1Skill7 : DefaultRangerSkill
	{
		public class Info
		{
			public int numberOfProjectile;

			public int intervalInFrames;

			public float distanceBetweenTwoProjectiles;

			public int flyingDelayInFrames;

			public Vector2 scaleFrom;

			public Vector2 scaleTo;

			public float scaleDuration;
		}

		private class StopIfTouchGround : Projectile.Trajectory
		{
			private Vector3 pos;

			private float delay;

			private bool isFirstUpdate;

			private float elapsed;

			public StopIfTouchGround(float delay, Vector3 pos)
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

		private class ScaleOverTime
		{
			private Vector2 from;

			private Vector2 to;

			private float duration;

			private GameObject go;

			private float elapsed;

			public ScaleOverTime(Vector2 from, Vector2 to, float duration, GameObject go)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private Info info;

		private List<EventFrame> originalEventFrames;

		private List<EventFrame> startupSwordVfxs;

		private List<EventFrame> impactSwordVfxs;

		private Dictionary<EventFrame, Vector2> vfxPosByEventFrame;

		private List<ScaleOverTime> sots;

		public Character1Skill7(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnCast(Character character)
		{
		}

		private EventFrame FindStartupVfxEventFrameOfWave(int waveOrder)
		{
			return null;
		}

		private EventFrame FindImpactVfxEventFrameOfWave(int waveOrder)
		{
			return null;
		}

		protected override bool UseCharacterFacingDirectionForCalculatingProjectileSpawnPosition()
		{
			return false;
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		private static EventFrame CreateEventFrame(float frameInSeconds, EventFrame damage, Vector2 relativeSpawnPos)
		{
			return null;
		}
	}
}
