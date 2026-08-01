namespace Assets.Scripts.Core.Skills
{
	public class BlessBuff : Buff
	{
		private float defBonus;

		private float attackBonus;

		private float heal;

		public float DefBonus => 0f;

		public float AttackBonus => 0f;

		public float Heal => 0f;

		public BlessBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float defBonus, float attackBonus, float heal, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
