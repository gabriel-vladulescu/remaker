using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Gizmo;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class StoneFormSkill : DefaultSkill
	{
		private SkillData skillData;

		private ProjectileFactory projectileFactory;

		private EntityWorld entityWorld;

		private Environment environment;

		private MovementComponent movementComponent;

		private Vector3 direction;

		private Entity me;

		private int directionRequestCount;

		private Vector3 positionAtStartOfSmashing;

		private Dictionary<Projectile, GizmoDrawRequest> gizmosDrawRequestByProjectiles;

		public StoneFormSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void PlayVfx(EventFrame ef)
		{
		}

		protected override DamageInfo ConstructDamageInfo(EventFrame eventFrame, int hitTargetId, Projectile projectile)
		{
			return null;
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override Vector3 DirectionTowardTarget(bool ignoreTargetY = false)
		{
			return default(Vector3);
		}

		private bool IsSmashingPhase()
		{
			return false;
		}
	}
}
