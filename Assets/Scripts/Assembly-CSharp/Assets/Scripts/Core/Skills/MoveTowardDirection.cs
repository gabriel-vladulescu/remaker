namespace Assets.Scripts.Core.Skills
{
	public class MoveTowardDirection
	{
		private float[] speed;

		private float[] duration;

		private float[] distance;

		private bool moveUntilReachTarget;

		private bool ignoreTargetY;

		private string animationName;

		private string skipAnimationName;

		private bool moveUntilReachBySpeed;

		public float[] Speed => null;

		public float[] Duration => null;

		public bool MoveUntilReachTarget => false;

		public bool IgnoreTargetY => false;

		public string AnimationName => null;

		public string SkipAnimationName => null;

		public float[] Distance => null;

		public bool MoveUntilReachBySpeed => false;

		public MoveTowardDirection(float[] speed, float[] duration, float[] distance, bool moveUntilReachTarget, bool moveUntilReachBySpeed, bool ignoreTargetY, string animationName, string skipAnimationName)
		{
		}
	}
}
