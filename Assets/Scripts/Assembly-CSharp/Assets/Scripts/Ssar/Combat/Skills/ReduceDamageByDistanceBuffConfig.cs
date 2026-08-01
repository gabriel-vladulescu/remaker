using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ReduceDamageByDistanceBuffConfig : BuffConfig
	{
		public float distance;

		public float from;

		public float to;

		public ReduceDamageByDistanceBuffConfig()
		{
		}

		public ReduceDamageByDistanceBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float distance, float from, float to)
		{
		}
	}
}
