using System;
using Artemis;
using Com.LuisPedroFonseca.ProCamera2D;

namespace SSAR.BattleSystem.Camera
{
	public class ZoomCameraControlData : AbsCameraControlData
	{
		private bool isFinish;

		private float zoomAmount;

		private float zoomDuration;

		private EaseType easeType;

		private Action onStart;

		private Action onFinish;

		public ZoomCameraControlData(CameraAccessLevel accessLevelLevel, float zoomAmount = -2f, float zoomDuration = 1f, EaseType easeType = EaseType.EaseOut, Action onStart = null, Action onFinish = null)
			: base(default(CameraAccessLevel))
		{
		}

		public override void Excute(Entity self)
		{
		}

		public override void Update(float deltaTime)
		{
		}

		public override bool Finished()
		{
			return false;
		}

		public override void OnExit()
		{
		}
	}
}
