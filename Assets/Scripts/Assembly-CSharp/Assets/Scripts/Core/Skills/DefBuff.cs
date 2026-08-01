namespace Assets.Scripts.Core.Skills
{
	public class DefBuff : Buff
	{
		private float bonus;

		public float Bonus => 0f;

		public DefBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetBonus(float bonus)
		{
		}
	}
}
