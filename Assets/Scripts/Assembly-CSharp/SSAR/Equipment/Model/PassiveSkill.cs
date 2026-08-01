using System;

namespace SSAR.Equipment.Model
{
	[Serializable]
	public class PassiveSkill
	{
		public string name;

		public int level;

		public string Name => null;

		public int Level => 0;

		public PassiveSkill()
		{
		}

		public PassiveSkill(string name, int level)
		{
		}
	}
}
