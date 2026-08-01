using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Common.System.Resources
{
	public interface ResourcesLoader
	{
		void SetLoadAssetsMode(LoadAssetsMode mode);

		void SetAssetVersionConfig(AssetsVersionConfig config);

		void SetBundleAssetsUrl(string url);

		void Load(LoadAssetRequest request);

		void Load(LoadMultiAssetsRequest request);

		void UnLoadAllBundle();

		T Load<T>(string resourcesPath) where T : Object;
	}
}
