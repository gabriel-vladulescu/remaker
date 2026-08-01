using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Craft.Model
{
	public class CraftingMaterialInventoryOverlay : IOverlay
	{
		private GameObject wgSelect;

		private CraftingMaterial craftingMaterial;

		public CraftingMaterialInventoryOverlay(CraftingMaterial craftingMaterial, GameObject wgSelect)
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
