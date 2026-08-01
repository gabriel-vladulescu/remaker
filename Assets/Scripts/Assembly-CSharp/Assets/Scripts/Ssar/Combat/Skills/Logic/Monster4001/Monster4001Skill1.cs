using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4001
{
	public class Monster4001Skill1 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			[Serializable]
			public class Phase1
			{
				public Trajectory minTrajectory;

				public Trajectory maxTrajectory;

				public float offsetDistance;
			}

			[Serializable]
			public class Phase2
			{
				public List<Trajectory> trajectories;

				public BallTrajectoryConfig ballTrajectory;

				public int maxBounce;
			}

			[Serializable]
			public class Trajectory
			{
				public float jumpHeight;

				public float jumpDurationReachMaxHeight;

				public float jumpDurationLandGround;

				public float floatingDuration;

				public float jumpDistance;
			}

			public Phase1 phase1;

			public Phase2 phase2;

			public float explodingDelay;

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

		private class CustomMelee : DefaultMeleeSkill
		{
			private readonly Monster4001Skill1 mainSkill;

			private Vector2 position;

			public CustomMelee(Monster4001Skill1 mainSkill, Dependencies dependencies)
				: base(null)
			{
			}

			protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
			{
			}

			protected override void OnProjectileCreated(Projectile projectile)
			{
			}

			protected override void OnProjectileFinishEvent(Projectile projectile)
			{
			}

			protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
			{
			}

			public void Spawn(Vector2 pos, EventFrame[] eventFrames)
			{
			}
		}

		private SkillInfo info;

		private float currentDirection;

		private int phase2BounceIndex;

		private EventFrame explodingFrame;

		private EventFrame poisonFrame;

		private EventFrame poisonFxFrame;

		private float hitGroundCd;

		private Direction startDirection;

		private bool isExploded;

		private float delayExplode;

		private CustomMelee meleeSkill;

		private float delayTurnOnParticles;

		private Projectile explodedProjectile;

		private State adjustAnimSpdState;

		private float originalAnimSpeed;

		public Monster4001Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		protected override bool ShouldPlayBeHitVfx()
		{
			return false;
		}

		private float GetDistanceToTarget()
		{
			return 0f;
		}

		private JumpTrajectoryConfig GetTrajectory(float distance)
		{
			return null;
		}

		private bool IsOutOfBounce()
		{
			return false;
		}

		private void SpawnExplode(Vector2 pos)
		{
		}

		private void SpawnPoison(Vector2 pos)
		{
		}
	}
}
