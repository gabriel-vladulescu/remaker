namespace Assets.Scripts.Core.Skills
{
	public class ImmuneBuff : Buff
	{
		private bool physical;

		private bool magical;

		private bool pure;

		private bool playLoopVfx;

		private bool playFlashVfx;

		public bool PlayLoopVfx => false;

		public bool PlayFlashVfx => false;

		public bool Physical => false;

		public bool Magical => false;

		public bool Pure => false;

		public ImmuneBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool playLoopVfx, bool physical, bool magical, bool pure, bool playFlashVfx, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
