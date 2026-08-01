using System.Collections.Generic;

namespace Scripts.Config
{
	public class AskForRateConfig : IConfig
	{
		public Dictionary<string, AskForRateInfo> info;

		public void OnMapValue(string content)
		{
		}

		public AskForRateInfo GetInfo()
		{
			return null;
		}
	}
}
