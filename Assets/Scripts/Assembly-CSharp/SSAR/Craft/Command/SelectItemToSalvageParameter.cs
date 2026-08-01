using Assets.Scripts.Model;

namespace Ssar.Craft.Command
{
	public class SelectItemToSalvageParameter
	{
		public IItem item;

		public bool isAdd;

		public SelectItemToSalvageParameter(IItem item, bool isAdd)
		{
		}
	}
}
