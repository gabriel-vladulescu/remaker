using System.Collections.Generic;
using Assets.Scripts.Ssar.SceneLoader;
using Assets.Scripts.Ssar.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.CharacterSelection.Command
{
	public class LoadCharacterSelectionScreenCmd : strange.extensions.command.impl.Command
	{
		private class PreloadRequest : AbsPreloadSceneAssetsRequest
		{
			private List<LoadAssetRequest> requests;

			protected override List<LoadAssetRequest> AssetsRequests()
			{
				return null;
			}

			private LoadAssetRequest LoadMainCharacter(int groupId, int subId)
			{
				return null;
			}
		}

		[Inject]
		public ShowCharacterSelectionPopupSignal ShowCharacterSelectionPopupSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}
	}
}
