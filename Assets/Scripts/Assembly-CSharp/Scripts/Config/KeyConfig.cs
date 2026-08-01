using System.Collections.Generic;

namespace Scripts.Config
{
	public class KeyConfig : IConfig
	{
		public Dictionary<string, KeyConfigElement> keys;

		public void OnMapValue(string content)
		{
		}

		public KeyConfigElement GetStaminaConfig()
		{
			return null;
		}

		public KeyConfigElement GetVideoPointConfig()
		{
			return null;
		}

		public KeyConfigElement GetArenaKeyConfig()
		{
			return null;
		}
	}
}
