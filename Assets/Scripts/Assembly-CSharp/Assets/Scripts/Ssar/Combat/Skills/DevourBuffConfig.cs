using System;
using Assets.Scripts.Core.Skills.Modifiers;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DevourBuffConfig : BuffConfig
	{
		public Vector2 runValue;

		public Vector2 dashValue;

		public Vector2 jumpValue;

		public DevourModifier.DirectionMode directionMode;

		public DevourBuffConfig()
		{
		}

		public DevourBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, Vector2 runValue, Vector2 dashValue, Vector2 jumpValue, DevourModifier.DirectionMode directionMode)
		{
		}
	}
}
