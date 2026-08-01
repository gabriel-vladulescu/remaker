using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Worldmap.View
{
	public class WorldMapPopupMediator : Mediator
	{
		[Inject]
		public WorldmapPopup view { get; set; }

		[Inject]
		public ReshowWorldMapSignal ReshowWorldMapSignal { get; set; }

		[Inject]
		public ChangeScenarioDifficultySignal ChangeScenarioDifficultySignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
