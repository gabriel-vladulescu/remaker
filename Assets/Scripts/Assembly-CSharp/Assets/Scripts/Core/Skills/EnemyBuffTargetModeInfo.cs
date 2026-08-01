using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class EnemyBuffTargetModeInfo : BuffTargetModeInfo
	{
		private Vector2 relativePositionToCaster;

		private float radius;

		public Vector2 RelativePositionToCaster => default(Vector2);

		public float Radius => 0f;

		public EnemyBuffTargetModeInfo(Vector2 relativePositionToCaster, float radius)
			: base(default(BuffTargetMode))
		{
		}
	}
}
