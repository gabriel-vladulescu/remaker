using System;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BuffTargetModeInfoConfig
	{
		public string targetMode;

		public BuffTargetModeInfoConfig()
		{
		}

		public BuffTargetModeInfoConfig(string targetMode)
		{
		}

		public BuffTargetMode ShowTargetMode()
		{
			return default(BuffTargetMode);
		}
	}
}
