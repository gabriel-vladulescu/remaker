using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3100
{
	public class Monster3100SkillVortex : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public List<ProjectileConfig> projectiles;
		}

		public class ProjectileConfig
		{
			public float activateTime;

			public Vector2 offsetPos;

			public float initialAngle;

			public float initialRadius;

			public float circularSpeed;

			public float radiusSpeed;
		}

		private SkillInfo skillInfo;

		private EventFrame damageFrame;

		private EventFrame vfxFrame;

		private Dictionary<EventFrame, ProjectileConfig> projectileConfigs;

		private Dictionary<EventFrame, Vector2> vfxPositions;

		private float startDirection;

		public Monster3100SkillVortex(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override void OnProjectileFinishEvent(Projectile projectile)
		{
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		protected override bool ShouldPlayBeHitVfx()
		{
			return false;
		}

		protected override bool ShouldPlayImpactVfx()
		{
			return false;
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		private EventFrame GetDamageFrame()
		{
			return null;
		}

		private SpiralTrajectoryConfig GenerateTrajectoryConfig(ProjectileConfig config)
		{
			return null;
		}

		private void SpawnProjectile(ProjectileConfig config)
		{
		}

		private void SpawnStartupVfx(float frame, Vector3 pos)
		{
		}
	}
}
