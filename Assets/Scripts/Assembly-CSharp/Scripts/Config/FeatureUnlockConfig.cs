using System.Collections.Generic;

namespace Scripts.Config
{
	public class FeatureUnlockConfig : IConfig
	{
		public Dictionary<string, FeatureUnlockInfo> features;

		public void OnMapValue(string content)
		{
		}

		private void Validate()
		{
		}

		public FeatureUnlockInfo GetFeatureUnlockInfo(FeatureName featureName)
		{
			return null;
		}
	}
}
