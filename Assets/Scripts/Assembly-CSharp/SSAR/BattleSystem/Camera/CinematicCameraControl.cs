using System;
using System.Collections.Generic;
using Artemis;
using Com.LuisPedroFonseca.ProCamera2D;

namespace SSAR.BattleSystem.Camera
{
	public class CinematicCameraControl : AbsCameraControlData
	{
		private float endDuration;

		private EaseType endEaseType;

		private List<CinematicTargetData> targetDatas;

		private bool isFinish;

		private CameraComponent cameraComponent;

		private Action onFinish;

		private float time;

		private bool cinematicfinished;

		private int playMode;

		public CinematicCameraControl(CameraAccessLevel accessLevelLevel, List<CinematicTargetData> targetDatas, float endDuration = 1f, EaseType endEaseType = EaseType.EaseOut, Action onFinish = null, int playMode = 1)
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

		private void CinematicFinish()
		{
		}
	}
}
