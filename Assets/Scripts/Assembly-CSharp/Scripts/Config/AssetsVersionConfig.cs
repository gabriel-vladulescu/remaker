using System.Collections.Generic;

namespace Scripts.Config
{
	public class AssetsVersionConfig : IConfig
	{
		public Dictionary<string, AssetsBundleData> assets;

		public AssetsBundleData GetAssetsBundleData(string bundleName)
		{
			return null;
		}

		public List<AssetsBundleData> GetList()
		{
			return null;
		}

		public void OnMapValue(string content)
		{
		}

		private int Comparer(AssetsBundleData a, AssetsBundleData b)
		{
			return 0;
		}
	}
}
