using System;
using UnityEngine;

namespace SSAR.BattleSystem.Camera
{
	[Serializable]
	public class ShakeCameraData
	{
		public Vector2 strength;

		public float duration;

		public int vibrato;

		public float smoothness;

		public float randomness;

		public bool useRandomInitialAngel;

		public Vector3 rotation;

		public ShakeCameraConfigId configId;

		public ShakeCameraData(Vector2 strength, float duration, int vibrato = 10, float smoothness = 0.01f, float randomness = 0f, bool useRandomInitialAngle = false)
		{
		}

		public ShakeCameraData(Vector2 strength, float duration, int vibrato, float smoothness, float randomness, bool useRandomInitialAngel, Vector3 rotation, ShakeCameraConfigId configId)
		{
		}
	}
}
