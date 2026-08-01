using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using SSAR.View;
using UnityEngine;

public class EquipmentPopup : BasePopup
{
	public EquipmentInventoryView inventoryView;

	public CharacterEquipmentView CharacterEquipmentView;

	public CharacterStatDetail CharacterStatDetail;

	public EquipmentInventoryTabView[] tabView;

	public GameObject resourcesContainer;

	private InventoryType curTab;

	private bool isFistTime;

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

	public void Back()
	{
	}

	public void OnRegister()
	{
	}

	public void UpdateInventoryAndCharacterEquipment(bool updateVisual)
	{
	}

	public void ShowInventoryWithTab(InventoryType tabType)
	{
	}

	private void NotifySeenCategory(InventoryType tabType)
	{
	}

	public void UpdateInventory()
	{
	}

	private void InitShortCut()
	{
	}

	private void CheckEnableShortCut()
	{
	}
}
