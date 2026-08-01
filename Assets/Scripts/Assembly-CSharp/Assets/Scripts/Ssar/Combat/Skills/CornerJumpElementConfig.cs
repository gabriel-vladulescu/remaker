using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CornerJumpElementConfig
	{
		public float distanceThreshold;

		public float height;

		public float durationReachMaxHeight;

		public float durationLandGround;

		public float DurationReachMaxHeight(float scaleTime)
		{
			return 0f;
		}

		public float DurationLandGround(float scaleTime)
		{
			return 0f;
		}
	}
}
