using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class AoeBuffTargetModeInfoConfig : BuffTargetModeInfoConfig
	{
		public Vector2 relativePositionToCaster;

		public float radius;

		public AoeBuffTargetModeInfoConfig()
		{
		}

		public AoeBuffTargetModeInfoConfig(Vector2 relativePositionToCaster, float radius)
		{
		}
	}
}
