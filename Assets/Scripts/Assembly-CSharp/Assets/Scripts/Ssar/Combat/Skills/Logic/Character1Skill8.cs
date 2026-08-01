using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character1Skill8 : DefaultMeleeSkill
	{
		public class SlashFlipController
		{
			private int count;

			public bool FlipValue()
			{
				return false;
			}
		}

		public class SlashLogic
		{
			private readonly float frame;

			private Slash config;

			private EventFrame vfxEventFrame;

			private Character1Skill8 skill;

			private readonly Vector2 centerOffset;

			private readonly AnimationCurve animationCurve;

			private readonly float viewPortResize;

			private readonly bool randomlyFlipSlash;

			private readonly float delayOfSlashDamageFrame;

			private readonly EventFrame slashDamageFrame;

			private readonly SlashFlipController sfc;

			private MoveHeroShadow mhs;

			private bool inited;

			private Vector4 boundary;

			private Vector4 originalBoundary;

			private float delayElapsed;

			private bool isDamageFrameDeal;

			public SlashLogic(float frame, Slash config, EventFrame vfxEventFrame, Character1Skill8 skill, Vector2 centerOffset, AnimationCurve animationCurve, float viewPortResize, bool randomlyFlipSlash, float delayOfSlashDamageFrame, EventFrame slashDamageFrame, SlashFlipController sfc)
			{
			}

			public void Update(float dt)
			{
			}

			public void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
			{
			}
		}

		public class MoveHeroShadow
		{
			private GameObject heroShadow;

			private Vector2 velocity;

			private float travelDistance;

			private readonly float travelDuration;

			private readonly AnimationCurve animationCurve;

			private Action onFinish;

			private bool finish;

			private Vector2 direction;

			private float elapsed;

			private Vector2 startPos;

			private Vector2 endPos;

			private float distanceOnX;

			private float distanceOnY;

			private Transform slashTransform;

			private Vector3 slashTransformOriginalPos;

			public MoveHeroShadow(GameObject heroShadow, Vector2 velocity, float travelDistance, float travelDuration, AnimationCurve animationCurve, Action onFinish)
			{
			}

			public void Update(float dt)
			{
			}
		}

		public class Info
		{
			public float slashStartAt;

			public int numberOfSlash;

			public float intervalBetweenSlash;

			public float whenDashHitFastForwardToFrame;

			public bool randomlyFlipSlash;

			public int startupFrameOfUppercutAnimation;

			public float playRecoveryAnimationAtFrame;

			public List<Slash> slashes;

			public int orderOfDashExtraDamageFrame;

			public Vector2 slashPivotOffset;

			public float slashDuration;

			public AnimationCurve slashCurve;

			public float viewPortResize;

			public int orderOfSlashDamageFrame;

			public float delayOfSlashDamageFrame;

			public float stopCameraFromTrackingAt;

			public float resumeCameraToTrackingAt;

			public string behitVfxPath;
		}

		public class Slash
		{
			public bool disable;

			public string direction;

			public int amplitudeInAngles;

			public float duration;

			public string animationName;

			public bool rorateTowardVelocity;

			public int valueForRandom;

			public int[] ShowAnglesInDegree()
			{
				return null;
			}

			public SlashDirection SlashDirectionEnum()
			{
				return default(SlashDirection);
			}
		}

		public enum SlashDirection
		{
			Left = 0,
			Right = 1,
			Up = 2,
			Down = 3,
			UpRight = 10,
			DownRight = 11
		}

		private Info info;

		private EventFrame dashDamageFrame;

		private EventFrame dashExtraDamageFrame;

		private EventFrame uppercutDamageFrame;

		private EventFrame slashDamageFrame;

		private bool adjustUppercutDamageFrame;

		private EventFrame slashVfxFrame;

		private EventFrame dashImpactVfxFrame;

		private List<SlashLogic> slashLogics;

		private bool isRecoveryAnimationPlayed;

		private List<EventFrame> processedEventFrames;

		private EventFrame dashEventFrame;

		private EventFrame jumpEventFrame;

		private List<EventFrame> damageFrames;

		private List<EventFrame> extraSlashFrames;

		private bool isCameraStopped;

		private bool isCameraResume;

		private bool isSlashFrameAdded;

		private bool camShakeAdjusted;

		private bool isMovementStopped;

		public Character1Skill8(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		private void BaseAddEventFrame(EventFrame ef)
		{
		}

		protected override bool IgnoreMinSpeedOnAirForDashes()
		{
			return false;
		}

		public override void OnCast(Character character)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void Jump(EventFrame ef)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}
	}
}
