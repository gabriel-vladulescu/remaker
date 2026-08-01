namespace Assets.Scripts.Core.Skills
{
	public class CursedBuff : Buff
	{
		private float attackBonus;

		private float movementSpeedBonus;

		public float AttackBonus => 0f;

		public float MovementSpeedBonus => 0f;

		public CursedBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float attackBonus, float movementSpeedBonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
