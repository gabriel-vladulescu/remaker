using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultDevourInfo : DevourModifier.Info
	{
		private float duration;

		private Vector2 runValue;

		private Vector2 dashValue;

		private Vector2 jumpValue;

		private DevourModifier.DirectionMode directionMode;

		public DefaultDevourInfo(float duration, Vector2 runValue, Vector2 dashValue, Vector2 jumpValue, DevourModifier.DirectionMode directionMode)
		{
		}

		public DefaultDevourInfo(DevourBuff devourBuff)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public Vector2 RunValue()
		{
			return default(Vector2);
		}

		public Vector2 DashValue()
		{
			return default(Vector2);
		}

		public Vector2 JumpValue()
		{
			return default(Vector2);
		}

		public DevourModifier.DirectionMode DirectionMode()
		{
			return default(DevourModifier.DirectionMode);
		}
	}
}
