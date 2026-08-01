using Assets.Scripts.Core.Skills.Modifiers;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class DevourBuff : Buff
	{
		public Vector2 runValue;

		public Vector2 dashValue;

		public Vector2 jumpValue;

		public DevourModifier.DirectionMode directionMode;

		public DevourBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, Vector2 runValue, Vector2 dashValue, Vector2 jumpValue, DevourModifier.DirectionMode directionMode)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
