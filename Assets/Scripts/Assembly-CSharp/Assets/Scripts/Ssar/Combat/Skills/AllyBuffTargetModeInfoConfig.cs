using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class AllyBuffTargetModeInfoConfig : BuffTargetModeInfoConfig
	{
		public Vector2 relativePositionToCaster;

		public float radius;

		public AllyBuffTargetModeInfoConfig()
		{
		}

		public AllyBuffTargetModeInfoConfig(Vector2 relativePositionToCaster, float radius)
		{
		}
	}
}
