using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.SkillSystem.View
{
	public class ControlLayoutPopupMediator : Mediator
	{
		[Inject]
		public ControlLayoutPopup view { get; set; }

		[Inject]
		public OnChangeControllerLayoutSignal OnChangeControllerLayoutSignal { get; set; }

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
