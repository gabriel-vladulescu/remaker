using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4101
{
	public class Monster4101Skill1 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			[Serializable]
			public class Trajectory
			{
				public JumpTrajectoryConfig minConfig;

				public JumpTrajectoryConfig maxConfig;

				public float offsetDistance;

				public float amplitude;

				public int density;
			}

			public List<Trajectory> trajectories;

			public float explodingDelay;
		}

		private class CustomMelee : DefaultMeleeSkill
		{
			private readonly Monster4101Skill1 mainSkill;

			private Vector2 position;

			public CustomMelee(Monster4101Skill1 mainSkill, Dependencies dependencies)
				: base(null)
			{
			}

			protected override void PlayAnimation(Character character)
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

		private Dependencies dependencies;

		private EventFrame poisonFrame;

		private EventFrame poisonFxFrame;

		private EventFrame bulletFrame;

		private float relativeLauchPosX;

		private List<CustomMelee> meleeSkills;

		private float delayTurnOnParticles;

		private int trajectoryCount;

		private List<Projectile> explodedProjectiles;

		public Monster4101Skill1(Dependencies dependencies)
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

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void OnProjectileFinishEvent(Projectile projectile)
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

		private void SpawnBullet()
		{
		}

		private SkillInfo.Trajectory GetTrajectory(int trajectoryCount)
		{
			return null;
		}

		private float GetDistanceToTarget(SkillInfo.Trajectory trajectory)
		{
			return 0f;
		}

		private JumpTrajectoryConfig GenerateTrajectoryConfig(SkillInfo.Trajectory trajectory, float distance)
		{
			return null;
		}

		private void SpawnPoison(Vector2 pos)
		{
		}
	}
}
