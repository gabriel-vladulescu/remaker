using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75004
{
	public class Monster75004Skill1 : DefaultMeleeSkill
	{
		public Monster75004Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		protected override bool ShouldPlayBeHitVfx(EventFrame eventFrame, Projectile projectile)
		{
			return false;
		}
	}
}
