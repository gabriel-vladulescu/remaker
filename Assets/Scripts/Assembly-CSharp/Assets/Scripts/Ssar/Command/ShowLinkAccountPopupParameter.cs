using System;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowLinkAccountPopupParameter
	{
		public Action OnSuccess { get; set; }

		public bool IsSave { get; set; }

		public ShowLinkAccountPopupParameter(Action onSuccess, bool isSave)
		{
		}
	}
}
