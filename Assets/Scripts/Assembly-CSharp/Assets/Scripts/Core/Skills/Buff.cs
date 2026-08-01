namespace Assets.Scripts.Core.Skills
{
	public class Buff
	{
		private BuffType type;

		private BuffTargetModeInfo buffTargetModeInfo;

		private float duration;

		private float successRate;

		private bool isLifeCycleDependOnParentSkill;

		public BuffType Type => default(BuffType);

		public BuffTargetModeInfo BuffTargetModeInfo => null;

		public float Duration => 0f;

		public float SuccessRate => 0f;

		public bool IsLifeCycleDependOnParentSkill => false;

		public Buff(BuffType type, BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill)
		{
		}

		public void SetDuration(float duration)
		{
		}

		public void SetSuccessRate(float rate)
		{
		}
	}
}
