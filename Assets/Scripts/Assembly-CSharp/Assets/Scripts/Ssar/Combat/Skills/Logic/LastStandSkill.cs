using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class LastStandSkill : DefaultMeleeSkill
	{
		private Character caster;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		private HpDropAttackBuffConfig buff;

		private bool justDropBelowLevel;

		private float attackBonus;

		public LastStandSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override bool IsFinish()
		{
			return false;
		}

		protected override void OnUpdate(float dt)
		{
		}
	}
}
