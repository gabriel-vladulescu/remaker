namespace Assets.Scripts.Core.Skills
{
	public class WildHowlBuff : Buff
	{
		private float atkBonus;

		public float AtkBonus => 0f;

		public WildHowlBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float atkBonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
