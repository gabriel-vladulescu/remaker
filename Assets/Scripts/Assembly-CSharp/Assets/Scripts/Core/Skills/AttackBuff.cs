namespace Assets.Scripts.Core.Skills
{
	public class AttackBuff : Buff
	{
		private float bonus;

		public float Bonus => 0f;

		public AttackBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetBonus(float bonus)
		{
		}
	}
}
