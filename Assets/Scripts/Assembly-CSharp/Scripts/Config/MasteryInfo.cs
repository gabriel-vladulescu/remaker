using SSAR.Equipment.Enum;
using Ssar.Rune.Model;

namespace Scripts.Config
{
	public class MasteryInfo
	{
		public string icon { get; set; }

		public int id { get; set; }

		public string name { get; set; }

		public string statType { get; set; }

		public string runeTypeRequireToLevelUp { get; set; }

		public bool enable { get; set; }

		public string localizeName { get; set; }

		public int order { get; set; }

		public StatType GetStatType()
		{
			return default(StatType);
		}

		public RuneType GetRuneType()
		{
			return default(RuneType);
		}
	}
}
