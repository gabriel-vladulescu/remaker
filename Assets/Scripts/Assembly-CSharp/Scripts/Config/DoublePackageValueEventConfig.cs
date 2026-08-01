using System.Collections.Generic;

namespace Scripts.Config
{
	public class DoublePackageValueEventConfig : IConfig
	{
		public class Config
		{
			public string mode;

			public Mode Mode => default(Mode);
		}

		public enum Mode
		{
			Time = 0,
			Weekly = 1
		}

		public Dictionary<string, Config> config;

		public Dictionary<string, DoublePackageValueEventInfo> info;

		public Dictionary<string, DoublePackageValueEventInfo> weekly;

		public void OnMapValue(string content)
		{
		}

		public DoublePackageValueEventInfo GetInfo(Mode mode)
		{
			return null;
		}

		public Mode GetMode()
		{
			return default(Mode);
		}
	}
}
