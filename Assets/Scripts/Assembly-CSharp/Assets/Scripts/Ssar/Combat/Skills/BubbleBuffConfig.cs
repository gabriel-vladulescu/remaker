using System;
using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BubbleBuffConfig : BuffConfig
	{
		public float damageInterval;

		public float damageScale;

		public bool playVfx;

		public string fxPath;

		public DamageType damageType;

		public Vector2 floatSpeed;

		public BubbleModifier.DirectionMode directionMode;

		public BubbleBuffConfig()
		{
		}

		public BubbleBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float damageInterval, float damageScale, string fxPath, DamageType damageType, Vector2 floatSpeed, BubbleModifier.DirectionMode directionMode)
		{
		}
	}
}
