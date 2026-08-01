using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Ancient
{
	public class Ancient7004Skill : DefaultAuraSkill
	{
		private float hpPerHeal;

		public Ancient7004Skill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void OnCasterTakingDamage(float damage)
		{
		}

		protected override void ActivateBuff(EventFrame buffEventFrame)
		{
		}
	}
}
