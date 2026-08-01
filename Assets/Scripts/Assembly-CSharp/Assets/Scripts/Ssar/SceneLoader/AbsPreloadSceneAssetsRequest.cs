using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.SceneLoader
{
	public abstract class AbsPreloadSceneAssetsRequest
	{
		public void Execute(Action<float> progress, Action finish)
		{
		}

		private void Preload(int index, List<LoadAssetRequest> request, Action<float> progress, Action completeDelegate)
		{
		}

		protected abstract List<LoadAssetRequest> AssetsRequests();
	}
}
