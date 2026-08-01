namespace Assets.Scripts.Core.Skills
{
	public class CcImmuneBuff : Buff
	{
		private bool isPurification;

		private bool enableVfx;

		public bool IsPurification => false;

		public bool EnableVfx => false;

		public CcImmuneBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill, bool isPurification, bool enableVfx)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
