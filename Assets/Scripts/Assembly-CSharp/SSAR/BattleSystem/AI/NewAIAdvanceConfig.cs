using System;
using System.Collections.Generic;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class NewAIAdvanceConfig : ICloneable
	{
		public string mobType;

		public float viewRange;

		[SerializeField]
		public List<TargetScore> group;

		[SerializeField]
		public List<TargetScore> tag;

		[SerializeField]
		public List<AIStateEffect> stateEffects;

		public Vector2 delayEnable;

		public void AddStateEffect(AIFlag flag)
		{
		}

		public AIStateEffect GetStateEffect(AIFlag flag)
		{
			return null;
		}

		public NewAIAdvanceConfig(string mobType)
		{
		}

		public void InitDefaultScore()
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
