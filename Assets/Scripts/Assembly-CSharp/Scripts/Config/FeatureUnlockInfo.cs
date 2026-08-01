namespace Scripts.Config
{
	public class FeatureUnlockInfo
	{
		public string featureName { get; set; }

		public bool enable { get; set; }

		public int levelRequire { get; set; }

		public int highestLevelRequire { get; set; }

		public string dungeonRequire { get; set; }

		public bool enableNotify { get; set; }

		public string icon { get; set; }

		public string localizeFeatureName { get; set; }

		public FeatureName GetFeatureName()
		{
			return default(FeatureName);
		}
	}
}
