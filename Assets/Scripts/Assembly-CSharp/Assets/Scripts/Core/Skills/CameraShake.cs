using SSAR.BattleSystem.Camera;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class CameraShake : CameraFx
	{
		private Vector2 strength;

		private float duration;

		private int vibrato;

		private float smoothness;

		private float randomness;

		private bool useRandomInitialAngel;

		private Vector3 rotation;

		private ShakeCameraConfigId configId;

		private CameraAccessLevel cameraAccessLevel;

		public Vector2 Strength => default(Vector2);

		public float Duration => 0f;

		public int Vibrato => 0;

		public float Smoothness => 0f;

		public float Randomness => 0f;

		public bool UseRandomInitialAngel => false;

		public Vector3 Rotation => default(Vector3);

		public ShakeCameraConfigId ConfigId => default(ShakeCameraConfigId);

		public CameraAccessLevel CameraAccessLevel
		{
			get
			{
				return default(CameraAccessLevel);
			}
			set
			{
			}
		}

		public CameraShake(Vector2 strength, float duration, int vibrato, float smoothness, float randomness, bool useRandomInitialAngel, Vector3 rotation, ShakeCameraConfigId configId, CameraAccessLevel cameraAccessLevel)
			: base(default(CameraFxType))
		{
		}
	}
}
