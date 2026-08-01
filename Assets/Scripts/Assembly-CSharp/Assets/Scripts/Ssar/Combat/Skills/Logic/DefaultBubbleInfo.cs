using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultBubbleInfo : BubbleModifier.Info
	{
		private float successRate;

		private float duration;

		private float damageInterval;

		private float damageScale;

		private bool shouldPlayVfx;

		private string fxPath;

		private DamageType damageType;

		private Vector2 floatSpeed;

		private BubbleModifier.DirectionMode directionMode;

		public DefaultBubbleInfo(float successRate, float duration, float damageInterval, float damageScale, bool shouldPlayVfx, string fxPath, DamageType damageType, Vector2 floatSpeed, BubbleModifier.DirectionMode directionMode)
		{
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public float DamageInterval()
		{
			return 0f;
		}

		public float DamageScale()
		{
			return 0f;
		}

		public bool ShouldPlayVfx()
		{
			return false;
		}

		public string FxPath()
		{
			return null;
		}

		public DamageType DamageType()
		{
			return default(DamageType);
		}

		public Vector2 FloatSpeed()
		{
			return default(Vector2);
		}

		public BubbleModifier.DirectionMode DirectionMode()
		{
			return default(BubbleModifier.DirectionMode);
		}
	}
}
