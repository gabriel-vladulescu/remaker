using Assets.Scripts.Model;

namespace SSAR.Equipment.Model
{
	public class ShowItemComparerParameter
	{
		public IItem LeftCollectData;

		public IItem rightCollectData;

		public bool showLeft;

		public EquipmentTarget EquipmentTarget;

		public ShowItemComparerParameter(IItem leftCollectData, IItem rightCollectData, EquipmentTarget equipmentTarget, bool showLeft = true)
		{
		}
	}
}
