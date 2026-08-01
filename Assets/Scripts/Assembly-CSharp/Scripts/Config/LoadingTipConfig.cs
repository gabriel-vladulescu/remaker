using System.Collections.Generic;

namespace Scripts.Config
{
	public class LoadingTipConfig : IConfig
	{
		public Dictionary<string, TipInfo> tips;

		private List<TipInfo> t;

		public void OnMapValue(string content)
		{
		}

		public List<TipInfo> GetTipInfos()
		{
			return null;
		}
	}
}
