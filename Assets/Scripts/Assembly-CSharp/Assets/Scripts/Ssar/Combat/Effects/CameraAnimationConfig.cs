using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	[Serializable]
	public class CameraAnimationConfig
	{
		public string animationName;

		public List<CameraShakeConfig> cameraShakeConfigs;

		public List<SlowMotionConfig> slowMotionConfigs;
	}
}
