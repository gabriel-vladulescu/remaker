using System;

namespace Ssar.BattleSystem.AISystem.Condition
{
	[Serializable]
	public class ConditionTypeToClassConfig
	{
		public ConditionType type;

		public string className;

		public ConditionTypeToClassConfig(ConditionType type)
		{
		}
	}
}
