using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class WarcryFxBuffConfig : BuffConfig
	{
		public float defBonus;

		public float attackBonus;

		public string startupFx;

		public string prefabFx;

		public Vector3 offset;

		public Vector3 scale;

		public WarcryFxBuffConfig()
		{
		}

		public WarcryFxBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate)
		{
		}
	}
}
