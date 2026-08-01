using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000001
{
	public class Monster2000001Skill1_2 : Monster2000001Skill1_1
	{
		private class DragTrajectory : CustomTrajectory
		{
			private EntityWorld entityWorld;

			private List<Character> targets;

			private Vector3 offset;

			private bool isStopped;

			private Vector3 stopPos;

			private float offsetLength;

			private float dragDuration;

			private const float DEFAULT_DURATION = 0.15f;

			public bool IsStopped => false;

			public DragTrajectory(float standbyTime, EntityWorld entityWorld)
				: base(0f)
			{
			}

			public void AddTarget(Character target, Vector3 offset)
			{
			}

			public void RemoveTarget(Character target)
			{
			}

			public void Stop(Vector3 stopPos)
			{
			}

			public override void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}

			private Vector3 GetTargetBodyOffset(Character target)
			{
				return default(Vector3);
			}
		}

		private List<EventFrame> vfxBreakEventFrames;

		private Dictionary<Projectile, DragTrajectory> trajectories;

		private Dictionary<Character, DragTrajectory> shackledTargets;

		private List<Projectile> deactivatedProjectiles;

		public Monster2000001Skill1_2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		protected override void SetTrajectory(Projectile projectile, float delay)
		{
		}
	}
}
