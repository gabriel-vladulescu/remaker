using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Common.System.Resources
{
	public class ResourcesSubSystem : SubSystem, ResourcesLoader
	{
		private AssetsLoader assetsLoader;

		public void StartUp()
		{
		}

		public void ShutDown()
		{
		}

		public void SetLoadAssetsMode(LoadAssetsMode mode)
		{
		}

		public void SetAssetVersionConfig(AssetsVersionConfig config)
		{
		}

		public void SetBundleAssetsUrl(string url)
		{
		}

		public void Load(LoadAssetRequest request)
		{
		}

		public void Load(LoadMultiAssetsRequest request)
		{
		}

		public void UnLoadAllBundle()
		{
		}

		public T Load<T>(string resourcesPath) where T : Object
		{
			return null;
		}
	}
}
