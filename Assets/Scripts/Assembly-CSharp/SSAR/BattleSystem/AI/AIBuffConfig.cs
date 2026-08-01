using System;
using System.Collections.Generic;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class AIBuffConfig : ICloneable
	{
		[Action("Value", "%")]
		public float value;

		[Action("Duration", null)]
		public float duration;

		[SerializeField]
		[Action("Action", null)]
		public ActionName action;

		[Action("ExcuteIn", null)]
		public ActionStateExcuteBuff excuteState;

		[Action("BuffType", null)]
		public AIBuffType buffType;

		[Action("Effect", null)]
		public string effectPath;

		[Action("Action Id", null)]
		public int actionId;

		[Action("Cooldown", null)]
		public float cooldown;

		public AIBuffName buffName;

		public string mobType;

		public AIBuffConfig(string mobType, AIBuffName buffName)
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
