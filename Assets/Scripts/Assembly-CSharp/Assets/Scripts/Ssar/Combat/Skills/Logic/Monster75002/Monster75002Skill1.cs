using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75002
{
	public class Monster75002Skill1 : DefaultMeleeSkill
	{
		public class Info
		{
			public float approachingMaxSpeed;

			public float approachingAcceleration;

			public float approachingOffsetRadius;

			public bool approachingOnXAxisOnly;

			public float drainingRadius;

			public float damageInterval;

			public Vector2 vfxMiddleControlPointOffset;

			public int vfxLineCount;

			public float startupVfxSpeedMultiplier;

			public float recoveryVfxSpeedMultiplier;

			public int soulCount;

			public float soulSpawnInterval;

			public float soulTravelDuration;

			public float drainStartAt;

			public string targetBodypart;

			public bool playBeHitVfx;

			public TargetBodypart ShowTargetBodypart()
			{
				return default(TargetBodypart);
			}
		}

		public enum TargetBodypart
		{
			Head = 0,
			Body = 1,
			Feet = 2
		}

		private class OffsetFollowTarget
		{
			private float maxSpeed;

			private float maxAcceleration;

			private Character target;

			private Character caster;

			private float approachingOffset;

			private readonly bool approachingOnXAxisOnly;

			private float elapsed;

			private bool stop;

			private Vector3 velocity;

			private Direction facingDirection;

			private Vector3 previousPos;

			private bool destinationReached;

			private float startY;

			public bool IsDestinationReached => false;

			public OffsetFollowTarget(float maxSpeed, float maxAcceleration, Character target, Character caster, float approachingOffset, bool approachingOnXAxisOnly)
			{
			}

			private void FaceLeft()
			{
			}

			private void FaceRight()
			{
			}

			public void Update(float dt)
			{
			}

			public void Stop()
			{
			}
		}

		private class PathFollower
		{
			private GameObject go;

			private Vector3[] controlPoints;

			private float travelDuration;

			private SplineWalker sw;

			public PathFollower(GameObject go, Vector3[] controlPoints, float travelDuration)
			{
			}

			public void Update(float dt)
			{
			}

			public bool IsFinish()
			{
				return false;
			}
		}

		private const string Skill1Startup = "Skill1_startup";

		private const string Skill1Active = "Skill1_active";

		private const string Skill1Recovery = "Skill1_recovery";

		private Info info;

		private Environment environment;

		private OffsetFollowTarget oft;

		private bool isTargetReached;

		private float startupAnimationDuration;

		private float activeAnimationDuration;

		private float recoveryAnimationDuration;

		private float startupElapsed;

		private bool startupAnimationPlayed;

		private bool activeAnimationPlayed;

		private bool recoveryAnimationPlayed;

		private float activeElapsed;

		private float recoveryElapsed;

		private Character target;

		private HealthComponent targetHealthComponent;

		private bool isFinish;

		private EventFrame vfxEventFrame;

		private EventFrame soulVfxEventFrame;

		private GameObject soulDrainVfx;

		private Vector3 lastPositionOfTarget;

		private float damageIntervalElapsed;

		private EventFrame damageFrame;

		private LineRenderer lr;

		private float runAnimationDuration;

		private float runAnimationElapsed;

		private List<PathFollower> pathFollowers;

		private float soulSpawnElapsed;

		private float drainStartAtElapsed;

		private bool drainPlayed;

		public Monster75002Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		private Vector3 TargetBodypartPosition()
		{
			return default(Vector3);
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override bool IsFinish()
		{
			return false;
		}

		public override bool IsChannelingFinish()
		{
			return false;
		}

		protected override void OnVfxFollowBonePlayed(EventFrame ef, List<GameObject> vfxs)
		{
		}

		private void PlayDrainVfx()
		{
		}

		private void StartDrainingTarget()
		{
		}
	}
}
