using System.Collections.Generic;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Projectiles
{
	public abstract class Projectile
	{
		private class EnemyWithDistanceToCaster
		{
			public float distance;

			public Character enemy;

			public EnemyWithDistanceToCaster(float distance, Character enemy)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public interface Trajectory
		{
			Direction AdjustCharacterFacingDirectionParam(Direction currentDirection, Direction directionAtTheTimeOfFirstProjectileCreation);

			Vector3 AdjustCharacterPositionParam(Vector3 currentCharacterPosition, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation);

			void Update(float dt, Projectile projectile, Vector3 currentPosition);
		}

		private Skill skill;

		private Collision collision;

		private Collider collider;

		private readonly float delayHandleObstacleCollision;

		private readonly float delayHandleObjectCollision;

		private List<Character> hitEnemiesSoFar;

		private Dictionary<string, object> extras;

		protected readonly ProjectileTargetFilterParams targetFilterParams;

		private bool isDestroyed;

		private float elapsed;

		private bool enabledCollision;

		private List<Character> filteredEnemies;

		private List<Character> filteredAllies;

		private List<Character> hitEnemiesSoFarBeforeThisCollision;

		private Character caster;

		private float projectileRadius;

		private float mostLeft;

		private float mostRight;

		protected Projectile(Skill skill, Collision collision, Collider collider, ProjectileTargetFilterParams targetFilterParams, float delayHandleObstacleCollision, float delayHandleObjectCollision)
		{
		}

		public virtual void UpdateCollidedTargets(float dt)
		{
		}

		public void FilterEnemies()
		{
		}

		public void UpdateHit()
		{
		}

		internal List<Character> GetFilteredEnemies()
		{
			return null;
		}

		internal void SetFilteredEnemies(List<Character> targets)
		{
		}

		internal bool IsFreePart()
		{
			return false;
		}

		internal int GetPartId()
		{
			return 0;
		}

		internal int GetHitboxId()
		{
			return 0;
		}

		internal int GetRehitRate()
		{
			return 0;
		}

		internal int MaxEnemyPerHit()
		{
			return 0;
		}

		internal bool CanHitEnemy()
		{
			return false;
		}

		internal bool CanHitAlly()
		{
			return false;
		}

		public float AgeInSeconds()
		{
			return 0f;
		}

		internal bool IsEnabledCollision()
		{
			return false;
		}

		internal void SetEnabledCollision(bool enabled)
		{
		}

		protected virtual List<Character> FindAdditionalCollidedCharacters()
		{
			return null;
		}

		public void PutExtras(string key, object extras)
		{
		}

		public object GetExtras(string key)
		{
			return null;
		}

		private bool IsCharacterVanish(Character character)
		{
			return false;
		}

		private List<Character> SortByDistanceAsc(List<Character> collidedEnemies)
		{
			return null;
		}

		private int EnemyWithDistanceToCasterComparer(EnemyWithDistanceToCaster e1, EnemyWithDistanceToCaster e2)
		{
			return 0;
		}

		protected void FilterHitEnemiesSoFar(List<Character> collidedEnemies)
		{
		}

		private List<Character> FilterCollidedEnemies(List<Character> collidedCharacters)
		{
			return null;
		}

		private List<Character> FilterCollidedAllies(List<Character> collidedCharacters)
		{
			return null;
		}

		protected virtual bool ShouldFilterMaxEnemyHitCount()
		{
			return false;
		}

		protected internal abstract Collider GetCollider();

		protected internal abstract List<Character> PickInterestedOnesFrom(List<Character> collidedCharacters);

		protected internal abstract void UpdateTrajectory(float dt);

		protected internal abstract bool IsFinish();

		protected abstract void OnDestroy();

		public abstract Vector3 Position();

		public abstract Vector3 Velocity();

		public abstract Quaternion Rotation();

		public abstract void SetVelocity(Vector3 velocity);

		public abstract void SetPosition(Vector3 newPosition);

		public abstract void SetTrajectory(Trajectory newTrajectory);

		public abstract Trajectory GetTrajectory();

		public void Destroy()
		{
		}
	}
}
