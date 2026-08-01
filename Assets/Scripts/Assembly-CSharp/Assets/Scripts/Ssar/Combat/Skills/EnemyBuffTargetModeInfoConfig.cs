using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class EnemyBuffTargetModeInfoConfig : BuffTargetModeInfoConfig
	{
		public Vector2 relativePositionToCaster;

		public float radius;

		public EnemyBuffTargetModeInfoConfig()
		{
		}

		public EnemyBuffTargetModeInfoConfig(Vector2 relativePositionToCaster, float radius)
		{
		}
	}
}
