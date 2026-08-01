using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	[Serializable]
	public class ProjectileMovementInfo
	{
		public int appearFrame;

		public Vector2 appearPositionOffset;

		public int scaleDurationInFrames;

		public Vector3 scaleFrom;

		public int standbyDurationInFrames;

		public int flyDurationInFrame;

		public Vector2 flyDestinationOffset;

		public Vector3 scale;

		public float AppearTime()
		{
			return 0f;
		}

		public float ScaleTime()
		{
			return 0f;
		}

		public float StandbyTime()
		{
			return 0f;
		}

		public float FlyTime()
		{
			return 0f;
		}
	}
}
