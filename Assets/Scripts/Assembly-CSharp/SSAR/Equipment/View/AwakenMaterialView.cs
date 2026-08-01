using System.Collections.Generic;
using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class AwakenMaterialView : EquipmentView
	{
		protected IItem equipmentCollectData;

		protected UIGrid table;

		private Dictionary<UIWidget, int> cache;

		protected override void Awake()
		{
		}

		protected virtual void Remove(GameObject go)
		{
		}

		public void Show(IItem equipmentCollectData, int index)
		{
		}

		public new void Hide()
		{
		}

		public bool IsThisMaterial(IItem equipmentCollectData)
		{
			return false;
		}
	}
}
