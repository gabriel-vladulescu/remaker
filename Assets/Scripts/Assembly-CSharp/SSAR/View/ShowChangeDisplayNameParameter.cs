using System;

namespace SSAR.View
{
	public class ShowChangeDisplayNameParameter
	{
		public Action OnHide { get; set; }

		public Action<string> Output { get; set; }

		public ShowChangeDisplayNameParameter(Action onHide, Action<string> output)
		{
		}
	}
}
