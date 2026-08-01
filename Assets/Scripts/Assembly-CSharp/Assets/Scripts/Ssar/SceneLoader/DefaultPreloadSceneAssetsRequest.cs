using System.Collections.Generic;

namespace Assets.Scripts.Ssar.SceneLoader
{
	public class DefaultPreloadSceneAssetsRequest : AbsPreloadSceneAssetsRequest
	{
		protected override List<LoadAssetRequest> AssetsRequests()
		{
			return null;
		}
	}
}
