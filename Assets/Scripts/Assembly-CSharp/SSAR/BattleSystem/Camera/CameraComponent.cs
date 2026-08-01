using System.Collections.Generic;
using Artemis;
using Artemis.Interface;
using Com.LuisPedroFonseca.ProCamera2D;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.Camera
{
	public class CameraComponent : IComponent
	{
		public Queue<AbsCameraControlData> queue;

		public AbsCameraControlData remote;

		public UnityEngine.Camera camera;

		public float targetLeftBoundary;

		public bool hasTargetLeftBoundary;

		public bool isShaking;

		private CameraSmoothData smoothData;

		private CameraBoundariesData boundariesData;

		private CameraWindowData windowData;

		private Transform target;

		public ProCamera2D ProCamera2D => null;

		public ProCamera2DNumericBoundaries ProCamera2DNumericBoundaries => null;

		public ProCamera2DShake ProCamera2DShake => null;

		public ProCamera2DCinematics ProCamera2DCinematics => null;

		public ProCamera2DCameraWindow CameraWindowData => null;

		public void SetCamera(UnityEngine.Camera camera)
		{
		}

		public void SetBoundaries(CameraBoundariesData boundariesData, bool smoothChangeLeftBoundary = false)
		{
		}

		public CameraBoundariesData GetBoundaries()
		{
			return null;
		}

		public void SetSmooth(CameraSmoothData smoothData)
		{
		}

		public void SetCameraWindow(CameraWindowData windowData)
		{
		}

		public void SetTarget(Transform target, CameraAccessLevel accessLevel)
		{
		}

		public void AddControl(AbsCameraControlData request)
		{
		}

		public void SetControl(AbsCameraControlData request, Entity self)
		{
		}

		public void RemoveControl()
		{
		}

		protected virtual bool IsRequestValid(AbsCameraControlData request)
		{
			return false;
		}

		public void ApplyBoundDaries()
		{
		}

		private void ApplyCameraTarget()
		{
		}

		private void ApplySmooth(CameraSmoothData smoothData)
		{
		}

		private void ApplyCameraWindowData()
		{
		}
	}
}
