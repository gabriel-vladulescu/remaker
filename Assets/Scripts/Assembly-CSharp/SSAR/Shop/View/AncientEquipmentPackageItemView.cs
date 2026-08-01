using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using Ssar.Ancient.View;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class AncientEquipmentPackageItemView : MonoBehaviour
	{
		public GameObject item_container;

		public AncientSkillView AncientSkillView;

		private EquipmentView equipmentView;

		private void Awake()
		{
		}

		public void Show(EquipmentConfigId equipmentConfigId, int randomEquipmentId)
		{
		}

		private void GetMinMaxTier(int randomEquipmentId, out EquipmentTier min, out EquipmentTier max)
		{
			min = default(EquipmentTier);
			max = default(EquipmentTier);
		}
	}
}
