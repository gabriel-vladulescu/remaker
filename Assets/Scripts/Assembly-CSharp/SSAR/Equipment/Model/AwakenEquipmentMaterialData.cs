using System.Collections.Generic;
using Assets.Scripts.Model;

namespace SSAR.Equipment.Model
{
	public class AwakenEquipmentMaterialData
	{
		private List<IItem> listMaterial;

		private IItem equipmentCollectData;

		public void Clear()
		{
		}

		public void SetMainEquipment(IItem equipmentCollectData)
		{
		}

		public void AddMaterial(IItem equipmentCollectData)
		{
		}

		public void RemoveMaterial(IItem equipmentCollectData)
		{
		}

		public List<IItem> GetMaterials()
		{
			return null;
		}

		public bool IsMaterial(IItem equipmentCollectData)
		{
			return false;
		}

		public float GetAwakenProgressWithMaterial()
		{
			return 0f;
		}

		public float GetAwakenProgressWithMaterialAndSoulLink()
		{
			return 0f;
		}

		private float GetLevelProgress(int bonusExp)
		{
			return 0f;
		}

		private int GetRawMaterialsExp()
		{
			return 0;
		}

		private int GetMaterialsExpWithSoulLink()
		{
			return 0;
		}

		public int MaterialCount()
		{
			return 0;
		}
	}
}
