namespace Assets.Scripts.Core.Skills
{
	public class WarcryBuff : Buff
	{
		private float defBonus;

		private float attackBonus;

		public float DefBonus => 0f;

		public float AttackBonus => 0f;

		public WarcryBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float defBonus, float attackBonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetAttackBonus(float bonus)
		{
		}

		public void SetDefBonus(float bonus)
		{
		}
	}
}
