using Scripts.Ssar.Arena;

namespace Scripts.Config
{
	public class ArenaRuneInfo
	{
		public string runeType { get; set; }

		public double runePower { get; set; }

		public double runeDuration { get; set; }

		public string nameLocalize { get; set; }

		public string descLocalize { get; set; }

		public string icon { get; set; }

		public RuneType GetRuneType()
		{
			return default(RuneType);
		}
	}
}
