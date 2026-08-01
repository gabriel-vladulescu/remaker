using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CameraShakeConfig : CameraFxConfig
	{
		public Vector2 cameraFxStrength;

		public float cameraFxDuration;

		public int cameraFxVibrato;

		public float cameraFxSmoothness;

		public float cameraFxRandomness;

		public bool cameraFxUseRandomInitialAngel;

		public Vector3 cameraFxRotation;
	}
}
