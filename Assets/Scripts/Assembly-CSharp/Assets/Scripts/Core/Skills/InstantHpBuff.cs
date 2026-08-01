namespace Assets.Scripts.Core.Skills
{
	public class InstantHpBuff : Buff
	{
		private float point;

		private float percent;

		private bool isShowDamage;

		private bool playVfx;

		public float Point => 0f;

		public float Percent => 0f;

		public bool IsShowDamage => false;

		public bool PlayVfx => false;

		public InstantHpBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float point, float percent, bool isShowDamage, bool playVfx, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetPercent(float percent)
		{
		}

		public void SetPoint(float point)
		{
		}
	}
}
