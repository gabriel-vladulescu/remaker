using System.Collections.Generic;

namespace Assets.Scripts.Ssar.SceneLoader
{
	public class TestPreloadSceneAssetsRequest : AbsPreloadSceneAssetsRequest
	{
		protected override List<LoadAssetRequest> AssetsRequests()
		{
			return null;
		}
	}
}
