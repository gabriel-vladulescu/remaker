using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Moves;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4006
{
	public class Monster4006Skill1 : DefaultMeleeSkill
	{
		private bool hited;

		private float checkHitDuration;

		public Monster4006Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnMoveTowardDirection(EventFrame ef, Assets.Scripts.Core.Skills.Moves.MoveTowardDirection m)
		{
		}

		private void ForceFrame()
		{
		}
	}
}
