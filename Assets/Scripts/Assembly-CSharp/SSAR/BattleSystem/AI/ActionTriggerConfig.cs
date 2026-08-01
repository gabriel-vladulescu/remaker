using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills.Modifiers;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class ActionTriggerConfig : ICloneable
	{
		[Action("Trigger Level", null)]
		public AITriggerLevel triggerLevel;

		[Action("Value", "/s")]
		public float pointPerSeconds;

		[Action("Value", "/hit")]
		public float pointPerHit;

		[Action("Value", null)]
		public float pointDeduct;

		[Action("Attack Range", null)]
		public float atkRange;

		[Action("Skill Range", null)]
		public float skillRange;

		[Action("Range", null)]
		public float range;

		[Action("RangeX", null)]
		public float rangeX;

		[Action("Action Name", null)]
		public ActionName actionName;

		[Action("Action Name", null)]
		public EntityAction entityAction;

		[Action("Hp Threshold", "%(Excute when hp smaller than)")]
		public float hpDrop;

		[Action("Hp Lost", "%(Excute every time when lost x hp)")]
		public float hpLost;

		[Action("ACtion Id", null)]
		public int actionId;

		[Action("Ignore Y", null)]
		public bool ignoreY;

		[Action("Rate", "%")]
		public float rate;

		[Action("Modifier", null)]
		public ModifierType modifier;

		[Action("Trigger Require", null)]
		public int attachTimesRequireInTime;

		[Action("Time", null)]
		public float timeThreshold;

		[Action("SkillId", null)]
		public string skillId;

		[Action("Reset Cooldown", null)]
		public bool resetCooldown;

		[Action("New Cooldown", null)]
		public float newCooldown;

		[Action("Hit Box Size", null)]
		public Vector2 hitBoxSize;

		[Action("Entity GroupId", null)]
		public int entityGroupId;

		public string mobType;

		public ActionTriggerType type;

		public ActionTriggerConfig(string mobType, ActionTriggerType type)
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
