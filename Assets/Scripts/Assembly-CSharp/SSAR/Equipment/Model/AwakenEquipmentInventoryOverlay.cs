using Assets.Scripts.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace SSAR.Equipment.Model
{
	public class AwakenEquipmentInventoryOverlay : IOverlay
	{
		private readonly IItem _equipmentCollectData;

		private GameObject wgSelect;

		public AwakenEquipmentInventoryOverlay(IItem equipmentCollectData, GameObject wgSelect)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public bool IsEnable()
		{
			return false;
		}

		public int Priority()
		{
			return 0;
		}
	}
}
