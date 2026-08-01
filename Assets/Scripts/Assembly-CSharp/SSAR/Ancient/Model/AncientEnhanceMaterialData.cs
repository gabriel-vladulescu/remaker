using System.Collections.Generic;
using SSAR.Equipment.Model;

namespace Ssar.Ancient.Model
{
	public class AncientEnhanceMaterialData
	{
		private List<EquipmentCollectData> materials;

		private EquipmentCollectData equipmentCollectData;

		internal void Clear()
		{
		}

		internal void SetMainAncient(EquipmentCollectData equipmentCollectData)
		{
		}

		internal void AddMaterial(EquipmentCollectData equipmentCollectData)
		{
		}

		internal void RemoveMaterial(EquipmentCollectData equipmentCollectData)
		{
		}

		internal bool IsMaterial(EquipmentCollectData equipmentCollectData)
		{
			return false;
		}

		internal List<EquipmentCollectData> GetMaterials()
		{
			return null;
		}

		internal int MaterialCount()
		{
			return 0;
		}

		internal bool IsMaxMaterialCount()
		{
			return false;
		}

		internal float GetProgressWithMaterial()
		{
			return 0f;
		}

		internal int GetTotalMaterialExp()
		{
			return 0;
		}
	}
}
