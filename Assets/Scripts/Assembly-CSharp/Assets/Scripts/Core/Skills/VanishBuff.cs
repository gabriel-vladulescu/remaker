namespace Assets.Scripts.Core.Skills
{
	public class VanishBuff : Buff
	{
		public VanishBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
