using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Craft.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingPopupSalvageView : strange.extensions.mediation.impl.View
	{
		public UILabel lbEquipmentCount;

		public UILabel lbDesc;

		public GameObject objEmptyItem;

		public GameObject btnSalvage;

		private BoxCollider btnSalvageCollider;

		public UIGrid gridEquipments;

		public UIGrid gridMaterials;

		private List<SalvageEquipmentView> equipmentViews;

		private List<CraftingMaterialView> materialViews;

		protected override void Awake()
		{
		}

		private void Salvage(GameObject go)
		{
		}

		private void Init()
		{
		}

		private void InitMaterials()
		{
		}

		private void ShowEquipments(List<IItem> items)
		{
		}

		private void ClearEquipments()
		{
		}

		private void ClearMaterials()
		{
		}

		private void ShowMaterials(List<IItem> items)
		{
		}

		private List<CraftingMaterial> GetListMaterials(List<IItem> items)
		{
			return null;
		}

		private void AddMaterialToList(CraftConfig.RarityRate[] data, List<CraftingMaterial> materials, HashSet<Rarity> rarities)
		{
		}

		internal void Show()
		{
		}

		internal void Hide()
		{
		}

		internal void UpdateData()
		{
		}
	}
}
