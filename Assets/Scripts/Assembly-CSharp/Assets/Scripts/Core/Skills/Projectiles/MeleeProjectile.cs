using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Projectiles
{
	public class MeleeProjectile : Projectile
	{
		public class MaxEnemyHitCountFilter
		{
			private readonly int maxEnemyHitCountPerHit;

			private readonly int numberOfHit;

			private readonly float intervalBetweenHit;

			private Dictionary<float, List<Character>> collidedCharactersesByElapsedTime;

			private float lastRecognizedElapsedTime;

			private bool isFirstHit;

			public MaxEnemyHitCountFilter(int maxEnemyHitCountPerHit, int numberOfHit, float intervalBetweenHit)
			{
			}

			public List<Character> FilterForThisHit(float elapsedTime, List<Character> collidedCharacters)
			{
				return null;
			}

			public bool IsMaxNumberOfHitExceeded()
			{
				return false;
			}

			public int NumberOfHit()
			{
				return 0;
			}

			private bool CheckValidHitTime(float elapsedTime)
			{
				return false;
			}
		}

		public class HitIntervalAndHitCountFilter
		{
			private int numberOfHit;

			private float intervalBetweenHit;

			private Dictionary<Character, int> charactersAndHitCount;

			private Dictionary<Character, float> charactersAndHitTime;

			public HitIntervalAndHitCountFilter(int numberOfHit, float intervalBetweenHit)
			{
			}

			public List<Character> TakeAction(float elapsed, List<Character> collidedCharacters)
			{
				return null;
			}
		}

		private Character character;

		private readonly Skill skill;

		private Collider collider;

		private float timeToLive;

		private readonly GameObject impactVfxPrefab;

		private readonly EffectPool effectPool;

		private readonly bool ignoreHeroPosOnYAxis;

		private readonly Vector3 characterPositionAtTheTimeOfFirstProjectileCreation;

		private readonly Direction characterFacingDirectionAtTheTimeOfFirstProjectileCreation;

		private float elapsed;

		private Trajectory trajectory;

		private MaxEnemyHitCountFilter maxEnemyHitCountFilter;

		private HitIntervalAndHitCountFilter hitIntervalAndHitCountFilter;

		private Vector3 velocity;

		public MeleeProjectile(Character character, Skill skill, Collision collision, Collider collider, ProjectileTargetFilterParams targetFilterParams, float timeToLive, float delayHandleObstacleCollision, float delayHandleObjectCollision, GameObject impactVfxPrefab, EffectPool effectPool, bool ignoreHeroPosOnYAxis, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation, Direction characterFacingDirectionAtTheTimeOfFirstProjectileCreation)
			: base(null, null, null, null, 0f, 0f)
		{
		}

		protected internal override Collider GetCollider()
		{
			return null;
		}

		protected override bool ShouldFilterMaxEnemyHitCount()
		{
			return false;
		}

		protected internal override List<Character> PickInterestedOnesFrom(List<Character> collidedCharacters)
		{
			return null;
		}

		protected internal override void UpdateTrajectory(float dt)
		{
		}

		protected internal override bool IsFinish()
		{
			return false;
		}

		protected override void OnDestroy()
		{
		}

		public override Vector3 Position()
		{
			return default(Vector3);
		}

		public override Vector3 Velocity()
		{
			return default(Vector3);
		}

		public override Quaternion Rotation()
		{
			return default(Quaternion);
		}

		public override void SetVelocity(Vector3 velocity)
		{
		}

		public override void SetPosition(Vector3 newPosition)
		{
		}

		public override void SetTrajectory(Trajectory newTrajectory)
		{
		}

		public override Trajectory GetTrajectory()
		{
			return null;
		}

		public void AdjustTimeToLive(float newValue)
		{
		}

		public void PlayImpactVfx(Vector3 pos)
		{
		}

		public bool IsImpactVfxPlayable()
		{
			return false;
		}
	}
}
