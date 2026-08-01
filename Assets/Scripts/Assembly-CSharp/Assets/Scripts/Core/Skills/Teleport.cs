using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class Teleport
	{
		private TeleportMode mode;

		private TeleportSide side;

		private float notificationFrame;

		private GameObject notificationPrefab;

		private Vector2 relativePosition;

		private float frameToTrackTargetPosition;

		private float padding;

		private bool isIgnoreTargetY;

		private float minDistanceToTarget;

		private float maxDistanceToTarget;

		private float offsetY;

		private float appearAtFrame;

		private bool lookAtTarget;

		public float AppearAtFrame => 0f;

		public bool LookAtTarget => false;

		public TeleportMode Mode => default(TeleportMode);

		public TeleportSide Side => default(TeleportSide);

		public float NotificationFrame => 0f;

		public GameObject NotificationPrefab => null;

		public Vector2 RelativePosition => default(Vector2);

		public float FrameToTrackTargetPosition => 0f;

		public float Padding => 0f;

		public bool IsIgnoreTargetY => false;

		public float MinDistanceToTarget => 0f;

		public float MaxDistanceToTarget => 0f;

		public float OffsetY => 0f;

		public Teleport(TeleportMode mode, TeleportSide side, float notificationFrame, GameObject notificationPrefab, Vector2 relativePosition, float frameToTrackTargetPosition, float padding, bool isIgnoreTargetY, float minDistanceToTarget, float maxDistanceToTarget, float offsetY, bool lookAtTarget, float appearAtFrame)
		{
		}

		public void SetRelativePosition(Vector2 relativePos)
		{
		}

		public void SetNotificationFrame(float frame)
		{
		}

		public void SetFrameToTrackTargetPosition(float frame)
		{
		}
	}
}
