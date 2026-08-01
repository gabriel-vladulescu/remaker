using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.StarChest.View
{
	public class StarChestProgressContainerMediator : Mediator
	{
		[Inject]
		public StarChestProgressContainer view { get; set; }

		[Inject]
		public OnOpenStarChestSuccessSignal openStarChestSuccessSignal { get; set; }

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
