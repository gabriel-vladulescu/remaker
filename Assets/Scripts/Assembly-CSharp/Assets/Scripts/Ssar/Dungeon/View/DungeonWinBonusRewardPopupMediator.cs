using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DungeonWinBonusRewardPopupMediator : Mediator
	{
		[Inject]
		public DungeonWinBonusRewardPopup view { get; set; }

		[Inject]
		public OnReceiveX2ItemSignal OnReceiveX2ItemSignal { get; set; }

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
