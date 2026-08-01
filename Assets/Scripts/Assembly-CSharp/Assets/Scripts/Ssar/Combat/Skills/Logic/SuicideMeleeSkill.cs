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
	public class SuicideMeleeSkill : DefaultSkill
	{
		private SkillData skillData;

		private ProjectileFactory projectileFactory;

		private EntityWorld entityWorld;

		private Environment environment;

		private Character character;

		private Dictionary<Projectile, GizmoDrawRequest> gizmosDrawRequestByProjectiles;

		private Vector3 direction;

		private MovementComponent movementComponent;

		private CharacterMediatorComponent characterMediatorComponent;

		private bool isFlying;

		private Entity me;

		public SuicideMeleeSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void PlayVfx(EventFrame ef)
		{
		}

		protected override Vector3 DirectionTowardTarget(bool ignoreTargetY = false)
		{
			return default(Vector3);
		}

		protected override DamageInfo ConstructDamageInfo(EventFrame eventFrame, int hitTargetId, Projectile projectile)
		{
			return null;
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		public override void Interrupt()
		{
		}

		protected void Suicide()
		{
		}

		protected void ClearGizmosDrawRequests()
		{
		}

		private void TurnFaceTowardTarget()
		{
		}
	}
}
