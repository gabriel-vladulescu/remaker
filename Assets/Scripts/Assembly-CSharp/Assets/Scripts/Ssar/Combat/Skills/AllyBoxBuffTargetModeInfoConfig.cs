using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class AllyBoxBuffTargetModeInfoConfig : BuffTargetModeInfoConfig
	{
		public Vector2 relativePositionToCaster;

		public Vector2 size;

		public AllyBoxBuffTargetModeInfoConfig()
		{
		}

		public AllyBoxBuffTargetModeInfoConfig(Vector2 relativePositionToCaster, Vector2 size)
		{
		}
	}
}
