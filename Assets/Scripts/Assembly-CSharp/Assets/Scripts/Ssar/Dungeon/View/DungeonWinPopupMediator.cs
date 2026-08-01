using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DungeonWinPopupMediator : Mediator
	{
		[Inject]
		public DungeonWinPopup view { get; set; }

		[Inject]
		public HideAllButtonAndOnlyShowLobbySignal HideAllButtonAndOnlyShowLobbySignal { get; set; }

		[Inject]
		public ClickBtnLobbySignal ClickBtnLobbySignal { get; set; }

		[Inject]
		public AddBonusExpFromWatchVodSignal AddBonusExpFromWatchVodSignal { get; set; }

		[Inject]
		public AddBonusSoulFromWatchVodSignal AddBonusSoulFromWatchVodSignal { get; set; }

		[Inject]
		public AddEquipmentFromWatchVodSignal AddEquipmentFromWatchVodSignal { get; set; }

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
