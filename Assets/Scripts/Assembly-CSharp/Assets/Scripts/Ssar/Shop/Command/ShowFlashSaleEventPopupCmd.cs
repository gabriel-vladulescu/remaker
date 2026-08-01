using System;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowFlashSaleEventPopupCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Action onClose { get; set; }

		public override void Execute()
		{
		}
	}
}
