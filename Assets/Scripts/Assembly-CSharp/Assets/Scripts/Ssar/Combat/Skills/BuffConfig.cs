using System;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BuffConfig
	{
		public string type;

		public BuffTargetModeInfoConfig buffTargetModeInfo;

		public float duration;

		public float successRate;

		public bool isLifeCycleDependOnParentSkill;

		public BuffConfig()
		{
		}

		public BuffConfig(string type, BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill = false)
		{
		}

		public BuffType ShowBuffType()
		{
			return default(BuffType);
		}
	}
}
