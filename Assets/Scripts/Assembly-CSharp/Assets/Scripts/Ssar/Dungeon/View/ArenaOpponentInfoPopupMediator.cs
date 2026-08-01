using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaOpponentInfoPopupMediator : Mediator
	{
		[Inject]
		public ArenaOpponentInfoPopup view { get; set; }

		[Inject]
		public HideArenaOpponentInfoPopupSignal HideArenaOpponentInfoPopupSignal { get; set; }

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
