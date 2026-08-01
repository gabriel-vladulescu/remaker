namespace Assets.Scripts.Core.Skills
{
	public class HolyBuff : Buff
	{
		private float damageReduction;

		private float attackBonus;

		private float instantHp;

		public float DamageReduction => 0f;

		public float AttackBonus => 0f;

		public float InstantHp => 0f;

		public HolyBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float damageReduction, float attackBonus, float instantHp, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
