namespace Assets.Scripts.Core.Skills
{
	public class BurnBuff : Buff
	{
		private float interval;

		private float damageScale;

		private bool playVfx;

		public float Interval => 0f;

		public float DamageScale => 0f;

		public bool PlayVfx => false;

		public BurnBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float interval, float damageScale, bool playVfx, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
