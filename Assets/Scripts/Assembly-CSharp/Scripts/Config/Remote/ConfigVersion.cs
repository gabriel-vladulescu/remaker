namespace Scripts.Config.Remote
{
	public class ConfigVersion
	{
		private const char delimiter = '.';

		private string rawValue;

		private int[] split;

		public int[] Split => null;

		public string RawValue => null;

		public ConfigVersion(string rawValue)
		{
		}

		public int Length()
		{
			return 0;
		}

		public bool GreaterThan(ConfigVersion other)
		{
			return false;
		}

		public bool EqualTo(ConfigVersion other)
		{
			return false;
		}

		public bool GreaterThanOrEqualTo(ConfigVersion other)
		{
			return false;
		}
	}
}
