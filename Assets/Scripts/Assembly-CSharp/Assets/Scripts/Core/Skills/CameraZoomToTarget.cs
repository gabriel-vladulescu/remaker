using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class CameraZoomToTarget : CameraFx
	{
		private CameraZoomToTargetType targetType;

		private Vector2 offset;

		private bool followTargetFacingDirection;

		private float easingDuration;

		private float holdingDuration;

		private float zoomLevel;

		private float endDuration;

		public CameraZoomToTargetType TargetType => default(CameraZoomToTargetType);

		public Vector2 Offset => default(Vector2);

		public bool FollowTargetFacingDirection => false;

		public float EasingDuration => 0f;

		public float HoldingDuration => 0f;

		public float ZoomLevel => 0f;

		public float EndDuration => 0f;

		public CameraZoomToTarget(CameraZoomToTargetType targetType, Vector2 offset, bool followTargetFacingDirection, float easingDuration, float holdingDuration, float zoomLevel, float endDuration)
			: base(default(CameraFxType))
		{
		}
	}
}
