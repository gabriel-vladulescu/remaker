using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class EnemyBoxBuffTargetModeInfoConfig : BuffTargetModeInfoConfig
	{
		public Vector2 relativePositionToCaster;

		public Vector2 size;

		public EnemyBoxBuffTargetModeInfoConfig()
		{
		}

		public EnemyBoxBuffTargetModeInfoConfig(Vector2 relativePositionToCaster, Vector2 size)
		{
		}
	}
}
