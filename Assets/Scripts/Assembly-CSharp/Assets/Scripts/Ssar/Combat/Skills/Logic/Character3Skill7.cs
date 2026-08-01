using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.EventTriggers;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Skill7 : DefaultRangerSkill
	{
		private class TetherWandering : Projectile.Trajectory
		{
			private float circleRadius;

			private float turnChance;

			private float mass;

			private float maxSpeed;

			private float maxForce;

			private float width;

			private float height;

			private Transform transform;

			private InitVelocity initVelocityMode;

			private float initVelocityMagnitude;

			private float openAngleInDegree;

			private Vector2 rectCenter;

			private Vector2 velocity;

			private Vector2 wanderForce;

			private Vector2 target;

			private float elapsed;

			private bool isFirstUpdate;

			private Projectile projectile;

			private Vector2 previousPos;

			private List<Vector2> targets;

			public TetherWandering(float circleRadius, float turnChance, float mass, float maxSpeed, float maxForce, float width, float height, Transform transform, InitVelocity initVelocityMode, float initVelocityMagnitude, float openAngleInDegree)
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

			private Vector2 GetWanderForce()
			{
				return default(Vector2);
			}

			private bool IsOutsideRect(Vector2 pos)
			{
				return false;
			}

			private Vector3 GetRandomWanderForce()
			{
				return default(Vector3);
			}

			private Vector3 Rect7h()
			{
				return default(Vector3);
			}

			private Vector3 Rect10h()
			{
				return default(Vector3);
			}

			private Vector3 Rect2h()
			{
				return default(Vector3);
			}

			private Vector3 Rect4h()
			{
				return default(Vector3);
			}
		}

		private class Info
		{
			public float circleRadius;

			public float turnChance;

			public float mass;

			public Vector2 rectSize;

			public float maxSpeed;

			public float maxSteeringForce;

			public int projectileCount;

			public int launchingIntervalInFrames;

			public string lauchingDirection;

			public float initVelocityMagnitude;

			public float openAngleInDegree;

			public Vector3 scaleFrom;

			public Vector3 scaleTo;

			public float scaleDuration;

			public LaunchingDirection ShowLaunchingDirection()
			{
				return default(LaunchingDirection);
			}
		}

		public enum LaunchingDirection
		{
			Random = 0,
			Palm = 1
		}

		private enum InitVelocity
		{
			Random = 0,
			Left = 1,
			Right = 2
		}

		private class MeleeSkill : DefaultMeleeSkill
		{
			public MeleeSkill(Dependencies dependencies)
				: base(null)
			{
			}

			protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
			{
			}
		}

		public class ScaleOverTime
		{
			private Vector3 from;

			private Vector3 to;

			private float duration;

			private GameObject go;

			private float elapsed;

			public ScaleOverTime(Vector3 from, Vector3 to, float duration, GameObject go)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private Info info;

		private EventFrame originalEventFrame;

		private MeleeSkill dms;

		private int eventTriggerCount;

		private List<List<EventFrame>> extraFrames;

		private List<ScaleOverTime> sots;

		public Character3Skill7(Dependencies dependencies)
			: base(null)
		{
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		public override void AddEventTrigger(EventTrigger et)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override List<Projectile> LaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		public override void Update(float dt)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		protected override bool UseCharacterFacingDirectionForCalculatingProjectileSpawnPosition()
		{
			return false;
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}
	}
}
