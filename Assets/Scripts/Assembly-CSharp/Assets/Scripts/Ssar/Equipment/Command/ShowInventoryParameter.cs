using SSAR.Equipment.Enum;
using SSAR.Equipment.View;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ShowInventoryParameter
	{
		public InventoryType type;

		public IGetCollectDataRule rule;

		public CollectDataComparer comparer;

		public AbstractInventoryView InventoryView;

		public ShowInventoryParameter(AbstractInventoryView inventory, InventoryType type, IGetCollectDataRule rule = null, CollectDataComparer comparer = null)
		{
		}
	}
}
