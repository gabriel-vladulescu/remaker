using System;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CameraCinematicMoveToRelativePositionConfig : CameraFxConfig
	{
		public Vector2 relativePos;

		public int easeType;

		public float durationInSeconds;

		public EaseType EaseTypeValue()
		{
			return default(EaseType);
		}
	}
}
