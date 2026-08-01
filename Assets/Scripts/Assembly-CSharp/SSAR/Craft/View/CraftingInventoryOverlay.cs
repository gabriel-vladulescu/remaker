using Assets.Scripts.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingInventoryOverlay : IOverlay
	{
		private readonly IItem equipmentCollectData;

		private readonly GameObject wgSelect;

		public CraftingInventoryOverlay(IItem equipmentCollectData, GameObject wgSelect)
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
