using System;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public abstract class CameraFxConfig
	{
		public string cameraFxType;

		public CameraFxConfig()
		{
		}

		public CameraFxConfig(CameraFxType cameraFxType)
		{
		}

		public CameraFxType CameraFxTypeValue()
		{
			return default(CameraFxType);
		}
	}
}
