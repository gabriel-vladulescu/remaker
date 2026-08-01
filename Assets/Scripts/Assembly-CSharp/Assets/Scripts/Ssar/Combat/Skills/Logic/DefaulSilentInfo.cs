using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaulSilentInfo : SilentModifier.Info
	{
		private float successRate;

		private float duration;

		private bool playVfx;

		public DefaulSilentInfo(float successRate, float duration, bool playVfx)
		{
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public bool PlayVfx()
		{
			return false;
		}

		public void SetDuration(float value)
		{
		}
	}
}
