using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill2 : DefaultRangerSkill
	{
		private class EndOfTrajectoryLifeCycle : DefaultRangerProjectile.LifeCycle
		{
			public bool End()
			{
				return false;
			}
		}

		private class CurveTrajectory : Projectile.Trajectory
		{
			private class DataPoint
			{
				private Vector2 previousPos;

				private Vector2 currentPos;

				private float dt;

				public Vector2 PreviousPos => default(Vector2);

				public Vector2 CurrentPos => default(Vector2);

				public float Dt => 0f;

				public DataPoint(Vector2 previousPos, Vector2 currentPos, float dt)
				{
				}
			}

			private Vector3 startVelocity;

			private float gravity;

			private Character character;

			private Character2Skill2Info info;

			private float travelingTime;

			private float distance;

			private float elapsedTime;

			private Vector2 startPos;

			private Vector2 destinationPos;

			private Direction currentDirection;

			private float characterPositionOnXAxisAtStartTime;

			private Queue<DataPoint> dataPoints;

			private Vector2 previousPos;

			private float elapsedTimeAtFullProgress;

			private bool endOfMove;

			private Vector2 offset;

			public CurveTrajectory(Character character, Direction currentDirection, Character2Skill2Info info, float travelingTime, float distance)
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

			private Vector2 CalculateVelocityBaseOnDataPoints()
			{
				return default(Vector2);
			}
		}

		public class Character2Skill2Info
		{
			public float invisibleStartTime;

			public float invisibleDuration;

			public AnimationCurve animationCurve;

			public Vector2 startVelocity;

			public float gravity;
		}

		private class Character2Skill2Melee : DefaultMeleeSkill
		{
			private Character2Skill2 _skill2;

			public Character2Skill2Melee(Character2Skill2 _skill2, Dependencies dependencies)
				: base(null)
			{
			}

			protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
			{
			}
		}

		private Character2Skill2Info info;

		private SkillData skillData;

		private readonly Environment environment;

		private List<EventFrame> processedEventFrames;

		private float distance;

		private float travelingTime;

		private Vector2 offsetPos;

		private DefaultMeleeSkill dms;

		private bool isInvisible;

		private bool isFinish;

		private float activeFrameStartAt;

		private bool isSkippedToDamageFrame;

		private float offsetOnY;

		private Vector3 displacement;

		private bool displaceForDamagePhase;

		private int sfxIndex;

		private Dictionary<Assets.Scripts.Core.Skills.Modifiers.ModifierType, bool> whiteList;

		private int counter;

		private int _frame;

		public Character2Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void PlaySfxRandomly(EventFrame ef)
		{
		}

		private void SkipToDamagePhase(Projectile projectile, EventFrame ef)
		{
		}

		protected override bool ShouldIgnoreThisHit(EventFrame ef, Projectile projectile, List<Character> hitCharacters)
		{
			return false;
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}
	}
}
