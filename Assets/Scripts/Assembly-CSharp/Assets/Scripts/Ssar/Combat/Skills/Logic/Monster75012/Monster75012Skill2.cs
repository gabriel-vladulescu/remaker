using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75012
{
	public class Monster75012Skill2 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public float activateTime;

			public int projectileCount;

			public float spawnInterval;

			public float initialAngle;

			public float radius;

			public float circularSpeed;

			public float refreshTime;

			public Vector2 offset;
		}

		private SkillInfo skillInfo;

		private EventFrame damageFrame;

		private EventFrame vfxFrame;

		private Dictionary<EventFrame, int> projectileIndexes;

		private List<int> indexes;

		private Dictionary<EventFrame, Vector2> vfxPositions;

		private float startDirection;

		private float baseAngle;

		private float delayStart;

		private float refreshInterval;

		public Monster75012Skill2(Dependencies dependencies)
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

		private EventFrame GetDamageFrame(int index)
		{
			return null;
		}

		private bool IsDelayStartTrajectory()
		{
			return false;
		}

		private float GetCurrentAngle(int index)
		{
			return 0f;
		}

		private float GetDelayTrajectory(int index)
		{
			return 0f;
		}

		private CircularTrajectoryConfig GenerateTrajectoryConfig(int index)
		{
			return null;
		}

		private Vector2 GetSpawnPos(int index)
		{
			return default(Vector2);
		}

		private void SpawnProjectile(int index)
		{
		}

		private void SpawnStartupVfx(int index, float frame, Vector3 pos)
		{
		}

		private void Refresh()
		{
		}
	}
}
