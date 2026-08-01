using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Ancient.Model
{
	public class AncientEnhanceInventoryOverlay : IOverlay
	{
		private readonly EquipmentCollectData equipmentCollectData;

		private GameObject wgSelect;

		public AncientEnhanceInventoryOverlay(EquipmentCollectData equipmentCollectData, GameObject wgSelect)
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
