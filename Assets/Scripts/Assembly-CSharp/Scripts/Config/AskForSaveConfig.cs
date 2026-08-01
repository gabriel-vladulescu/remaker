using System.Collections.Generic;

namespace Scripts.Config
{
	public class AskForSaveConfig : IConfig
	{
		public Dictionary<string, AskForSaveInfo> info;

		public void OnMapValue(string content)
		{
		}

		public AskForSaveInfo GetInfo()
		{
			return null;
		}
	}
}
