using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CameraSlowMotionConfig : CameraFxConfig
	{
		public float timeScale;

		public int endFrame;

		public float duration;
	}
}
