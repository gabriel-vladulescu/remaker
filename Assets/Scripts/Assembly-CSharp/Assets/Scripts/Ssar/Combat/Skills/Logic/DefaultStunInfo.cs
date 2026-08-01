using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultStunInfo : StunModifier.StunInfo
	{
		private float successRate;

		private float duration;

		private bool playVfx;

		private float animTransitionTime;

		public DefaultStunInfo(float successRate, float duration, bool playVfx, float animTransitionTime = 0.3f)
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

		public float AnimTransitionTime()
		{
			return 0f;
		}
	}
}
