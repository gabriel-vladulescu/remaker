using System;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CameraZoomToTargetConfig : CameraFxConfig
	{
		public string targetType;

		public Vector2 offset;

		public bool followTargetFacingDirection;

		public float easingDuration;

		public float holdingDuration;

		public float zoomLevel;

		public float endDuration;

		public CameraZoomToTargetType TargetTypeValue()
		{
			return default(CameraZoomToTargetType);
		}
	}
}
