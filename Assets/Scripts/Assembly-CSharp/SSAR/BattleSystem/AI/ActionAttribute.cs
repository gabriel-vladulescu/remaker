using System;

namespace SSAR.BattleSystem.AI
{
	public class ActionAttribute : Attribute
	{
		private string name;

		private string additional;

		public ActionAttribute(string name, string additional = "")
		{
		}

		public string GetName()
		{
			return null;
		}

		public string GetAdditional()
		{
			return null;
		}
	}
}
