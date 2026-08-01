using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class SettingPopupMediator : Mediator
	{
		[Inject]
		public SettingPopup view { get; set; }

		[Inject]
		public HideSettingPopupSIgnal HideSettingPopupSIgnal { get; set; }

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
