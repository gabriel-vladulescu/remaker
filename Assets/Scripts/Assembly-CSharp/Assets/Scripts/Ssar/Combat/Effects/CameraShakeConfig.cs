using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	[Serializable]
	public class CameraShakeConfig
	{
		public int frame;

		public Vector2 cameraFxStrength;

		public float cameraFxDuration;

		public int cameraFxVibrato;

		public float cameraFxSmoothness;

		public float cameraFxRandomness;

		public bool cameraFxUseRandomInitialAngel;

		public Vector3 cameraFxRotation;
	}
}
