using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class AoeBuffTargetModeInfo : BuffTargetModeInfo
	{
		private Vector2 relativePositionToCaster;

		private float radius;

		public Vector2 RelativePositionToCaster => default(Vector2);

		public float Radius => 0f;

		public AoeBuffTargetModeInfo(Vector2 relativePositionToCaster, float radius)
			: base(default(BuffTargetMode))
		{
		}
	}
}
