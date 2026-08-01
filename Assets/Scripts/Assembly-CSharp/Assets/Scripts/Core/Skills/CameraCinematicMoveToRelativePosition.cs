using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class CameraCinematicMoveToRelativePosition : CameraFx
	{
		private Vector2 relativePos;

		private EaseType easeType;

		private float durationInSeconds;

		public Vector2 RelativePos => default(Vector2);

		public EaseType EaseType => default(EaseType);

		public float DurationInSeconds => 0f;

		public CameraCinematicMoveToRelativePosition(Vector2 relativePos, EaseType easeType, float durationInSeconds)
			: base(default(CameraFxType))
		{
		}
	}
}
