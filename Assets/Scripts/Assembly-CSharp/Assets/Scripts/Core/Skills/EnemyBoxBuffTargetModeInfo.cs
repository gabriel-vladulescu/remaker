using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class EnemyBoxBuffTargetModeInfo : BuffTargetModeInfo
	{
		private Vector2 relativePositionToCaster;

		private Vector2 size;

		public Vector2 RelativePositionToCaster => default(Vector2);

		public Vector2 Size => default(Vector2);

		public EnemyBoxBuffTargetModeInfo(Vector2 relativePositionToCaster, Vector2 size)
			: base(default(BuffTargetMode))
		{
		}
	}
}
