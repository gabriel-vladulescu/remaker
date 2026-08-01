using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using Ssar.Rune.Model;
using UnityEngine;

public class InventoryTools
{
	public static void ShowEquipmentInInventory(EquipmentCollectData equipmentCollectData, UILabel lb_name, UILabel lb_tier, UILabel lb_rarity, UILabel lb_enhance, UISprite sp_rarity, UISprite sp_icon, bool isCraftMode = false)
	{
	}

	public static void ShowEquipmentInSlot(int groupId, int subId, EquipmentCollectData equipmentCollectData, UILabel lb_tier, UILabel lb_rarity, UILabel lb_enhance, UISprite sp_rarity, UISprite sp_icon, bool isCraftMode = false)
	{
	}

	private static void ShowEquipmentEnhanceLevel(EquipmentCollectData equipmentCollectData, UILabel lb_enhance)
	{
	}

	public static void ShowAwakenLevel(IItem item, UILabel lb_enhance, AwakenLevelView awakenLevelView)
	{
	}

	public static void ShowRuneInInventory(Rune rune, UILabel lb_name, UILabel lb_quantity, UISprite sp_rarity, UISprite sp_icon)
	{
	}

	public static void ShowRuneInInventory(RuneType runeType, RuneRarity runeRarity, int count, UILabel lb_name, UILabel lb_quantity, UISprite sp_rarity, UISprite sp_icon)
	{
	}

	public static void ShowMaterialInInventory(CraftingMaterial material, UILabel lb_name, UILabel lb_quantity, UISprite sp_rarity, UISprite sp_icon)
	{
	}

	public static void ShowMaterialInInventory(CraftingMaterialType type, Rarity rarity, int count, UILabel lb_name, UILabel lb_quantity, UISprite sp_rarity, UISprite sp_icon)
	{
	}

	public static GameObject MapClassValue<T>(GameObject item) where T : MonoBehaviour
	{
		return null;
	}

	public static void MoveToItemCollectID(AbstractInventoryView inventoryView, int collectID)
	{
	}

	public static void UpdateInventoryAndKeepPoint(AbstractInventoryView inventoryView, List<ICollectData> collectDatas)
	{
	}

	private static BaseInventoryRowView GetHighestRow(List<BaseInventoryRowView> rowViews)
	{
		return null;
	}

	private static int GetEndRowData(AbstractInventoryView inventoryView, List<ICollectData> collectDatas, int curRow)
	{
		return 0;
	}

	private static List<BaseInventoryRowView> GetListRowVisible(InventoryRowWrapContent wrapContent)
	{
		return null;
	}

	public static bool IsRowVisible(InventoryRowWrapContent wrapContent, Transform transform)
	{
		return false;
	}

	public static void ShowPetInInventory(PetCollectData petCollectData, UILabel lb_name, UILabel lb_tier, UILabel lb_rarity, UILabel lb_enhance, UISprite sp_rarity, UISprite sp_icon)
	{
	}

	public static void ShowPetInSlot(PetCollectData petCollectData, UILabel lb_tier, UILabel lb_rarity, UILabel lb_enhance, UISprite sp_rarity, UISprite sp_icon)
	{
	}

	private static int GetRowWithCollectID(AbstractInventoryView inventoryView, int collectID)
	{
		return 0;
	}

	private static void ShowRow(int index, int curRow, AbstractInventoryView inventoryView)
	{
	}

	private static int ComparerPosition(BaseInventoryRowView a, BaseInventoryRowView b)
	{
		return 0;
	}
}
