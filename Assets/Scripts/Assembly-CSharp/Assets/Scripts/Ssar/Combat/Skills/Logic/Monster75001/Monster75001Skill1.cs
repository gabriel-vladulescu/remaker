using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75001
{
	public class Monster75001Skill1 : DefaultRangerSkill
	{
		private class Tracker
		{
			private Projectile projectile;

			private float duration;

			private Monster75001Skill1 skill;

			private DelayedTrajectory delayedTrajectory;

			private GameObject go;

			private float elapsed;

			private RangerDamage rd;

			private Character nearestTarget;

			private Vector3 projectilePos;

			public Tracker(Projectile projectile, float duration, Monster75001Skill1 skill, DelayedTrajectory delayedTrajectory)
			{
			}

			public void Update(float dt)
			{
			}
		}

		public class Info
		{
			public float floatingDuration1;

			public float floatingDuration2;

			public float floatingDuration3;
		}

		private class DelayedTrajectory : Projectile.Trajectory
		{
			private float delayDuration;

			private Vector3 startPosition;

			private float elapsed;

			private Vector2 velocity;

			private Vector3 previousPosition;

			public DelayedTrajectory(float delayDuration, Vector3 startPosition)
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

			public void SetVelocity(Vector2 v)
			{
			}

			public void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}
		}

		private Info info;

		private int projectileCount;

		private List<Tracker> trackers;

		private Vector3 defaultTargetPosition;

		public Monster75001Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		private Vector3 TargetBodypartPosition(Character target)
		{
			return default(Vector3);
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override Vector3 OverrideProjectilePositionForRangerProjectileTowardTarget(EventFrame ef, Vector3 currentPosition)
		{
			return default(Vector3);
		}

		protected override void OnUpdate(float dt)
		{
		}
	}
}
