using System;
using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using Ssar.Craft.Enum;
using Ssar.Craft.View;

namespace Ssar.Craft.Model
{
	public class CraftingDataManager
	{
		private CraftingTabType tabType;

		private Rarity[] filterRarities;

		private CraftingMaterial craftingMaterial;

		private List<IItem> salvageItems;

		private CraftableItem craftableItem;

		private CraftableItemView craftableItemView;

		private Action onChangeCraftable;

		public const int MAX_SALVAGE_QUANTITY = 20;

		public static readonly Rarity[] DEFAULT_FILTER_RARIRTIES;

		public void SetTabType(CraftingTabType tabType)
		{
		}

		public CraftingTabType GetTabType()
		{
			return default(CraftingTabType);
		}

		public void SelectMaterial(CraftingMaterial material)
		{
		}

		public bool IsSelectedMaterial(CraftingMaterial material)
		{
			return false;
		}

		public CraftingMaterial GetMaterial()
		{
			return null;
		}

		public Rarity[] GetFilteRarities()
		{
			return null;
		}

		public void SetFilterRarities(Rarity[] rarities)
		{
		}

		public void ResetFilterRarities()
		{
		}

		public bool IsFullSalvage()
		{
			return false;
		}

		public void AddSalvageItem(IItem collectData)
		{
		}

		public void RemoveSalvageItem(IItem collectData)
		{
		}

		public bool IsSelectedSalvage(IItem collectData)
		{
			return false;
		}

		public List<IItem> GetSalvageItems()
		{
			return null;
		}

		public void ClearSalvage()
		{
		}

		public int GetSalvageItemCount()
		{
			return 0;
		}

		public void ListenOnChangeCraftable(Action action)
		{
		}

		public void UnistenOnChangeCraftable(Action action)
		{
		}

		public void SelectCraftableItem(CraftableItem item, CraftableItemView itemView = null)
		{
		}

		public bool IsSelectedCraftableItem(CraftableItem item)
		{
			return false;
		}

		public CraftableItem GetCraftableItem()
		{
			return null;
		}

		public CraftableItemView GetCraftableItemView()
		{
			return null;
		}

		public void ClearCraftable()
		{
		}
	}
}
