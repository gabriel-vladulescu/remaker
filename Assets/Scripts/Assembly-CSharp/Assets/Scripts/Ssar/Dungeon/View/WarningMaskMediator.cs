using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class WarningMaskMediator : Mediator
	{
		[Inject]
		public WarningMaskView view { get; set; }

		[Inject]
		public UpdateMainCharacterHealthSignal UpdateMainCharacterHealthSignal { get; set; }

		[Inject]
		public SetEnableWarningMaskSignal SetEnableWarningMaskSignal { get; set; }

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
