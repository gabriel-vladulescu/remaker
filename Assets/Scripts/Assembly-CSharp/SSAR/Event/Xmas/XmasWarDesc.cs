namespace Ssar.Event.Xmas
{
	public class XmasWarDesc
	{
		public int id { get; set; }

		public string name { get; set; }

		public string pointDesc { get; set; }

		public int point { get; set; }

		public static int Comparer(XmasWarDesc a, XmasWarDesc b)
		{
			return 0;
		}
	}
}
