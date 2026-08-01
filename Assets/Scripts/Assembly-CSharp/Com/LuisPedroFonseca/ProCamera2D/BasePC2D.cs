using System;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	public abstract class BasePC2D : MonoBehaviour
	{
		public ProCamera2D ProCamera2D;

		protected Func<Vector3, float> Vector3H;

		protected Func<Vector3, float> Vector3V;

		protected Func<Vector3, float> Vector3D;

		protected Func<float, float, Vector3> VectorHV;

		protected Func<float, float, float, Vector3> VectorHVD;

		protected Transform _transform;

		private bool _enabled;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void OnReset()
		{
		}

		private void Enable()
		{
		}

		private void Disable()
		{
		}

		private void ResetAxisFunctions()
		{
		}
	}
}
