namespace Ssar.Event.DemonInvasion.Config
{
	public class DemonInvasionRank
	{
		public int id { get; set; }

		public int time { get; set; }

		public string name { get; set; }

		public int soul { get; set; }

		public int token { get; set; }

		public static int Comparer(DemonInvasionRank a, DemonInvasionRank b)
		{
			return 0;
		}
	}
}
