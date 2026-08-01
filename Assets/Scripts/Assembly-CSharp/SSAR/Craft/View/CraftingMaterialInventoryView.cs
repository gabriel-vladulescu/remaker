using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Command;
using SSAR.Equipment.View;

namespace Ssar.Craft.View
{
	public class CraftingMaterialInventoryView : AbstractInventoryView
	{
		protected override void OnShowInventory(List<ICollectData> collectData, ShowInventoryParameter parameter)
		{
		}

		public override string GetRowPath()
		{
			return null;
		}

		protected override int GetNumChildOfRow()
		{
			return 0;
		}
	}
}
