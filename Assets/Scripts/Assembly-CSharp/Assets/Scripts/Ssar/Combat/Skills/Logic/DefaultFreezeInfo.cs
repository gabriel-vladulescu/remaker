using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultFreezeInfo : FreezeModifier.Info
	{
		private float duration;

		private float successRate;

		private bool playMaterialVfx;

		private bool playLockVfx;

		public DefaultFreezeInfo(float duration, float successRate, bool playMaterialVfx, bool playLockVfx)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public bool ShouldPlayMaterialVfx()
		{
			return false;
		}

		public bool ShouldPlayLockVfx()
		{
			return false;
		}
	}
}
