namespace Assets.Scripts.Core.Skills
{
	public class SilentBuff : Buff
	{
		public bool playVfx;

		public bool PlayVfx => false;

		public SilentBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill, bool playVfx)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
