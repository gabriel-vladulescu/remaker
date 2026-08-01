using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultShackleInfo : ShackleModifier.ShackleInfo
	{
		private float successRate;

		private float duration;

		private bool playVfx;

		private string vfxPath;

		public DefaultShackleInfo(float successRate, float duration, bool playVfx, string vfxPath)
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

		public string GetVfxPath()
		{
			return null;
		}
	}
}
