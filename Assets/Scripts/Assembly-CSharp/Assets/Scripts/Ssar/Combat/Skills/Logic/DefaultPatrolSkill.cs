using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultPatrolSkill : DefaultMeleeSkill
	{
		private CharacterMediatorComponent mediatorComponent;

		private MovementComponent movementComponent;

		public DefaultPatrolSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		private void SetDirectionToTarget()
		{
		}
	}
}
