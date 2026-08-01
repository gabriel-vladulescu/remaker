using SSAR.Equipment.Enum;
using Ssar.Reforge.Command;
using Ssar.Reforge.Enum;

namespace Ssar.Reforge.View
{
	public class ReforgeResultConfirmPopup : BasePopup
	{
		public ReforgeComparerContainer ComparerContainer;

		private ShowReforgeResultConfirmParameter parameter;

		public void Show(ShowReforgeResultConfirmParameter parameter)
		{
		}

		private void OnClickKeepOrignal()
		{
		}

		private void OnClickTakeNew()
		{
		}

		private void SendReforgeKeepMetric(ReforgeType runeType, EquipmentType equipmentType, Rarity rarity)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}
	}
}
