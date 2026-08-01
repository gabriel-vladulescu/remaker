using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75005
{
	public class Monster75005Skill2 : DefaultMeleeSkill
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

			private Monster75005Skill2 skill;

			private readonly Vector2 centerOffset;

			private readonly AnimationCurve animationCurve;

			private readonly float viewPortResize;

			private readonly bool randomlyFlipSlash;

			private readonly float delayOfSlashDamageFrame;

			private readonly EventFrame slashDamageFrame;

			private readonly SlashFlipController sfc;

			private readonly Direction facingDirection;

			private readonly int slashPositionRandomFactorMultiplier;

			private readonly float slashPositionRandomFactorUnit;

			private readonly bool useCasterPositionAsStartPosition;

			private MoveHeroShadow mhs;

			private bool inited;

			private Vector4 boundary;

			private Vector4 originalBoundary;

			private float delayElapsed;

			private bool isDamageFrameDeal;

			public SlashLogic(float frame, Slash config, EventFrame vfxEventFrame, Monster75005Skill2 skill, AnimationCurve animationCurve, float viewPortResize, bool randomlyFlipSlash, float delayOfSlashDamageFrame, EventFrame slashDamageFrame, SlashFlipController sfc, Direction facingDirection, int slashPositionRandomFactorMultiplier, float slashPositionRandomFactorUnit, bool useCasterPositionAsStartPosition)
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

			public bool randomlyFlipSlash;

			public float playRecoveryAnimationAtFrame;

			public List<Slash> slashes;

			public int orderOfDashExtraDamageFrame;

			public Vector2 slashPivotOffset;

			public float slashDuration;

			public AnimationCurve slashCurve;

			public int orderOfSlashDamageFrame;

			public float delayOfSlashDamageFrame;

			public int slashPositionRandomFactorMultiplier;

			public float slashPositionRandomFactorUnit;

			public bool firstSlashStartFromCasterPosition;
		}

		public class Slash
		{
			public bool disable;

			public string direction;

			public int amplitudeInAngles;

			public float duration;

			public bool rorateTowardVelocity;

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

		private EventFrame slashDamageFrame;

		private EventFrame slashVfxFrame;

		private List<SlashLogic> slashLogics;

		private bool isRecoveryAnimationPlayed;

		private List<EventFrame> damageFrames;

		public Monster75005Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		private void BaseAddEventFrame(EventFrame ef)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}
	}
}
