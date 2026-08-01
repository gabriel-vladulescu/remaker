using SSAR.Entry.Model;
using SSAR.View;
using UnityEngine;

public class ChestPopup : BasePopup
{
	public ChestInventoryView InventoryView;

	public ChestTabView[] RuneInventoryTabViews;

	private ChestTabType curTab;

	public GameObject resourcesContainer;

	private ShortCutFindItem shortCutFindItem;

	protected override void Awake()
	{
	}

	protected override void onEnable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private void InstantiateResources()
	{
	}

	private void InitTab()
	{
	}

	private void ShowTab()
	{
	}

	public void Show()
	{
	}

	public void OnRegister()
	{
	}

	public void UpdateInventoryAndCharacterEquipment()
	{
	}

	public void ShowInventoryWithTab(ChestTabType tabType)
	{
	}

	private void NotifySeenCategory(ChestTabType tabType)
	{
	}

	public void UpdateInventory()
	{
	}

	private void InitShortCutFindItem()
	{
	}

	private void CheckEnableShortCut()
	{
	}
}
