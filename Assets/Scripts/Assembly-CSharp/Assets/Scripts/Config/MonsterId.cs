namespace Assets.Scripts.Config
{
	public class MonsterId
	{
		private string rawValue;

		private int groupId;

		private int subId;

		private int level;

		public string RawValue => null;

		public int GroupId => 0;

		public int SubId => 0;

		public int Level => 0;

		public MonsterId(string rawValue)
		{
		}

		public MonsterId(int groupId, int subId, int level)
		{
		}

		public bool Equals(MonsterId other)
		{
			return false;
		}
	}
}
