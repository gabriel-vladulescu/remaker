using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.AI;
using UnityEngine;

namespace Ssar.BattleSystem.AISystem.Condition
{
	[Serializable]
	public class ConditionConfig
	{
		[Action("Enable", null)]
		public bool enable;

		[Action("Is Right Edge", null)]
		public bool isRightEdge;

		[Action("Check Left Or Right", null)]
		public bool checkLeftRight;

		[Action("Value", "/s")]
		public float pointPerSeconds;

		[Action("Position Offset", null)]
		public Vector2 posOffset;

		[Action("Hit box min", null)]
		public Vector2 hitBoxSizeMin;

		[Action("Hit box max", null)]
		public Vector2 hitBoxSizeMax;

		[Action("Check Target In Front Of", null)]
		public bool checkTargetInFrontOf;

		[Action("Action Duration", null)]
		public float[] originalDuration;

		[Action("Require", null)]
		public bool require;

		[Action("Reverse", null)]
		public bool reverse;

		[Action("Reset Poin If False", null)]
		public bool resetPoint;

		[Action("Short Time Used Skill", null)]
		public float shortTime;

		[Action("SkillId", null)]
		public string skillId;

		[Action("Rate", null)]
		public float rate;

		[Action("Self SkillId", null)]
		public string selfSkillId;

		[Action("Threshold", null)]
		public float threshold;

		[Action("React Time", null)]
		public Vector2 reactTime;

		[Action("Modifier", null)]
		public ModifierType modifierType;

		[Action("Range X", null)]
		public Vector2 rangeX;

		[Action("Draw Gizmo", null)]
		public bool drawGizmo;

		[Action("Duration after Cast Skill", "s")]
		public float timeToDealDamageOfSkill;

		[Action("Is Check Self", null)]
		public bool isSelf;

		[Action("GroupId", null)]
		public int groupId;

		[Action("Hold", "s")]
		public float holdDuration;

		[Action("Offset Y", null)]
		public float offsetY;

		public ConditionType type;

		public ConditionConfig(ConditionType type)
		{
		}

		public List<string> GetListPropertyAvailable()
		{
			return null;
		}

		public object Clone()
		{
			return null;
		}
	}
}
