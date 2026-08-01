using System;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class NewAIDelayEnableConfig : ICloneable
	{
		public string mobType;

		public float step;

		public NewAIDelayEnableConfig(string mobtype)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
