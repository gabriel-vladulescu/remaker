using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using UnityEngine;

public class SellAllEquipmentPopup : BasePopup
{
	public UILabel lb_count;

	public UILabel lb_price;

	public UITable table_category;

	public UITable table_rarity;

	public UITable table_price;

	public GameObject btn_close;

	public GameObject btn_sell;

	private List<SellAllEquipmentRarityBox> rarityBoxs;

	private List<SellAllEquipmentCategoryBox> categoryBoxs;

	private List<EquipmentCombinedType> categories;

	private List<Rarity> rarities;

	private int currentCount;

	private int currentPrice;

	private List<IItem> list;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(EquipmentCombinedType defaultCategory)
	{
	}

	private void InitDefaultWhenShow(EquipmentCombinedType equipmentCombinedType)
	{
	}

	private void Clear()
	{
	}

	private void UpdateTextCount(int count)
	{
	}

	private void InitRarityBox()
	{
	}

	private void InitCategoryBox()
	{
	}

	private void TickBoxRariry(Rarity rarity)
	{
	}

	private void UnTickBoxRarity(Rarity rarity)
	{
	}

	private void TickBoxCategory(EquipmentCombinedType category)
	{
	}

	private void UnTickBoxCategory(EquipmentCombinedType category)
	{
	}

	private void UpdateListEquipmentCanSell()
	{
	}

	private void Sell(GameObject o)
	{
	}
}
