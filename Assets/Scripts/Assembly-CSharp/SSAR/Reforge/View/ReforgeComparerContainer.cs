using System;
using SSAR.Entry.Model;
using SSAR.Equipment.Model;
using Ssar.Reforge.Enum;
using strange.extensions.mediation.impl;

namespace Ssar.Reforge.View
{
	public class ReforgeComparerContainer : strange.extensions.mediation.impl.View
	{
		public ReforgeComparerView originalEquipmentView;

		public ReforgeComparerView reforgedEquipmentView;

		private bool isInited;

		public void Init(Action cbKeep, Action cbTake)
		{
		}

		public void ShowComparer(EquipmentCollectData originalEquipment, EquipmentCollectData reforgeEquipment, ReforgeType reforgeType, bool enableKeep)
		{
		}

		public void Hide()
		{
		}

		private int GetBoundIndex(ReforgeType reforgeType)
		{
			return 0;
		}

		private void FormatNewStatToDiff(ref ComparerItemResult comparerItemResult)
		{
		}
	}
}
