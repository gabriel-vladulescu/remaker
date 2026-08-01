using System;
using Assets.Scripts.Ssar.SceneLoader.View;

namespace Assets.Scripts.Ssar.SceneLoader
{
	public class LoadSceneRequest
	{
		public AbsSceneLogic SceneLogic;

		public AbsPreloadSceneAssetsRequest preloadSceneAssetsRequest;

		public Action onFinish;

		public LoadingSceneType LoadingSceneType;

		public bool showModel;

		public bool autoDestroyLoadingScene;

		public float minTime;

		public bool enableTip;

		public bool enableInterstitialAds;

		public LoadSceneRequest(AbsSceneLogic sceneLogic, AbsPreloadSceneAssetsRequest preloadSceneAssetsRequest, Action onFinish, bool enableTip, LoadingSceneType showLoadingScene = LoadingSceneType.Model, bool autoDestroyLoadingScene = true, float minTime = 0f, bool enableInterstitialAds = false)
		{
		}
	}
}
