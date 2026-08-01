using System;
using SSAR.Equipment.Model;

namespace Assets.Scripts.Ssar.Command
{
	public class OpenRandomEquipmentTicketParameter
	{
		public ItemInfo ItemInfo;

		public Action<EquipmentCollectData> result;

		public Action finishFx;

		public bool showPopup;

		public bool disableWhenFinish;

		public OpenRandomEquipmentTicketParameter(ItemInfo itemInfo, Action<EquipmentCollectData> result, Action finishFx, bool showPopup, bool disableWhenFinish)
		{
		}
	}
}
