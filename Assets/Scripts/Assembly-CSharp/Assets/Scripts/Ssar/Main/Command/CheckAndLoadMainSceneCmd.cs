using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.SceneLoader;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Main.Command
{
	public class CheckAndLoadMainSceneCmd : strange.extensions.command.impl.Command
	{
		private class MainScenePreloadAssetsRequest : AbsPreloadSceneAssetsRequest
		{
			protected override List<LoadAssetRequest> AssetsRequests()
			{
				return null;
			}

			private LoadAssetRequest LoadMainCharacter()
			{
				return null;
			}

			private LoadAssetRequest DailyLoginPopup()
			{
				return null;
			}

			private LoadAssetRequest EquipmentPopup()
			{
				return null;
			}

			private LoadAssetRequest SkillManagerPopup()
			{
				return null;
			}
		}

		[Inject]
		public Action onFinish { get; set; }

		[Inject]
		public bool showModel { get; set; }

		[Inject]
		public int enableInterstitialAds { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}
	}
}
