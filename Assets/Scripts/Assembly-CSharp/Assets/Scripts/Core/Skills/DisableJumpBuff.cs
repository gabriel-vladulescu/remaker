namespace Assets.Scripts.Core.Skills
{
	public class DisableJumpBuff : Buff
	{
		public DisableJumpBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill1)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
