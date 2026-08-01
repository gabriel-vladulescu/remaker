using System;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class ActionNameToClassConfig
	{
		public ActionName type;

		public string className;

		public ActionNameToClassConfig(ActionName type)
		{
		}
	}
}
