using System;

namespace Scripts.Config.Remote
{
	public interface MaintenancePopup
	{
		void Show(Action<MaintenancePopupAction> resultCallback);
	}
}
