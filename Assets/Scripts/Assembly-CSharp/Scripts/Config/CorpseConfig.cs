using System.Collections.Generic;

namespace Scripts.Config
{
	public class CorpseConfig : IConfig
	{
		public Dictionary<string, CorpseInfo> info;

		public void OnMapValue(string content)
		{
		}

		public CorpseInfo GetCorpseInfo()
		{
			return null;
		}
	}
}
