namespace Assets.Scripts.Core.Skills
{
	public class BloodBondBuff : Buff
	{
		public BloodBondBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
