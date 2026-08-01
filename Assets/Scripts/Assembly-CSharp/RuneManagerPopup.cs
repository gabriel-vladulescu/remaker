using Assets.Scripts.Ssar.Rune.Enum;
using Assets.Scripts.Ssar.Rune.View;
using SSAR.Equipment.Model;
using SSAR.View;
using Ssar.Reforge.View;
using Ssar.Rune.Model;
using UnityEngine;

public class RuneManagerPopup : BasePopup
{
	public RuneInventoryView InventoryView;

	public RuneInventoryView InventoryViewOre;

	public RuneInventoryTabView[] RuneAndOreTabViews;

	public RuneInventoryTabView[] RuneInventoryTabViews;

	public GameObject runeInfoContainer;

	public GameObject runeInfoContainerRight;

	public GameObject equipmentInfoContainer;

	public GameObject equipmentForgeContainer;

	public GameObject resourcesContainer;

	public GameObject subTabContainer;

	private RuneInventoryTabType curMainTab;

	private RuneInventoryTabType curSubTab;

	private RuneInfoView runeInfoView;

	private RuneManagerPopupEquipmentSelectInfo m_equipmentInfoContainer;

	private EquipmentCollectData equipmentCollectData;

	private Rune rune;

	private ViewRuneInfoType viewType;

	private RuneManagerPopupEquipmentForge equipmentForge;

	private ShortCutFindItem shortCutFindItem;

	protected override void Awake()
	{
	}

	private void InstantiateResources()
	{
	}

	private void InitTab()
	{
	}

	private void InitRuneInfo()
	{
	}

	private void InitEquipmentInfoContainer()
	{
	}

	private void InitEquipmentForgeContainer()
	{
	}

	public void Back()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void OnDisable()
	{
	}

	public void Show(Rune rune)
	{
	}

	private RuneInventoryTabType ConvertToTab(RuneType runeType, bool isMainTab)
	{
		return default(RuneInventoryTabType);
	}

	public void Show(EquipmentCollectData equipmentCollectData)
	{
	}

	public void SetRuneInfoAnchorLeft()
	{
	}

	public void SetRuneInfoAnchorRight()
	{
	}

	private void ShowMainTab()
	{
	}

	private void ShowSubTabs(bool silent = false)
	{
	}

	private void ShowRuneInfo(Rune rune, ViewRuneInfoType viewType)
	{
	}

	private void ShowEquipmentInfo(EquipmentCollectData equipmentCollectData)
	{
	}

	public void OnRegister()
	{
	}

	private void ShowInventoryWithMainTab(RuneInventoryTabType tabType)
	{
	}

	private void ShowInventoryWithSubTab(RuneInventoryTabType tabType)
	{
	}

	private void ShowInventoryWithTab(RuneInventoryTabType tabType)
	{
	}

	private void NotifySeenCategory(RuneInventoryTabType tabType)
	{
	}

	public void UpdateInventory()
	{
	}

	private RuneInventoryTabType GetCurrentInventoryTab()
	{
		return default(RuneInventoryTabType);
	}

	private bool IsOreTab(RuneInventoryTabType tabType)
	{
		return false;
	}

	public void OnCombineSuccess()
	{
	}

	public void OnDisassembleSuccess()
	{
	}

	private void CheckAndUpdateRuneInfo()
	{
	}

	public void SelectRune(Rune rune)
	{
	}

	public void OnEquipRuneSuccess()
	{
	}

	public void OnUnEquipRuneSuccess()
	{
	}

	public void OnReforgeSuccess()
	{
	}

	public void OnReforgeResultConfirmed()
	{
	}

	private void InitShortCutFindItem()
	{
	}

	private void CheckEnableShortCut(RuneInventoryView runeInventoryView)
	{
	}
}
