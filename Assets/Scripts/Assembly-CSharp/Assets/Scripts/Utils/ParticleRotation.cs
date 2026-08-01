using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	[ExecuteInEditMode]
	public class ParticleRotation : MonoBehaviour
	{
		public enum FLIP_MODE
		{
			FLIP = 0,
			ROTATION_TRANSFORM = 1,
			ROTATION_PARTICLE = 2,
			ROTATION_WITH_STARTSPEED = 3,
			FLIP_SCALE_AND_ROTATION = 4,
			NATIVE_BONE_FOLLOWER = 5
		}

		private interface Logic
		{
			void Act();

			void Undo();
		}

		private class FlipLogic : Logic
		{
			private GameObject gameObject;

			private Vector3 originalLocalScale;

			public FlipLogic(GameObject gameObject)
			{
			}

			public void Act()
			{
			}

			public void Undo()
			{
			}
		}

		private class RotateTransformLogic : Logic
		{
			private GameObject gameObject;

			private Quaternion originalLocalRotation;

			public RotateTransformLogic(GameObject gameObject)
			{
			}

			public void Act()
			{
			}

			public void Undo()
			{
			}
		}

		private class RotateParticleLogic : Logic
		{
			private GameObject gameObject;

			private ParticleSystem.MinMaxCurve originalMinMaxCurve;

			private ParticleSystem.MinMaxCurve originalMinMaxY;

			public RotateParticleLogic(GameObject gameObject)
			{
			}

			public void Act()
			{
			}

			public void Undo()
			{
			}
		}

		private class RotateWithStartSpeed : Logic
		{
			private GameObject gameObject;

			private ParticleSystem.MinMaxCurve originalStartSpeed;

			public RotateWithStartSpeed(GameObject gameObject)
			{
			}

			public void Act()
			{
			}

			public void Undo()
			{
			}
		}

		private class FlipScaleAndRotation : Logic
		{
			private GameObject gameObject;

			private Vector3 originalLocalScale;

			private Quaternion originalLocalRotation;

			private Vector3 axisRotation;

			private Vector3 axisFlip;

			public FlipScaleAndRotation(GameObject gameObject, Vector3 axisFlip, Vector3 axisRotation)
			{
			}

			public void Act()
			{
			}

			public void Undo()
			{
			}
		}

		public bool isFlip;

		public FLIP_MODE mode;

		public Vector3 axisRotation;

		public Vector3 axisFlip;

		public Vector2 velocity;

		public bool rotate;

		private bool currentFlip;

		private bool currentRotate;

		private Dictionary<FLIP_MODE, Logic> logicByFlipMode;

		private void Awake()
		{
		}

		public void Flip()
		{
		}

		public void ResetFlip()
		{
		}

		public void ResetAllFlips()
		{
		}

		public void Rotate(Vector2 velocity)
		{
		}
	}
}
