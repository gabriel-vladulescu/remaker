using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.CharacterSelection.View;
using UnityEngine;

public class CharacterSelectionPopup : BasePopup
{
	public static int selectedSetItemId;

	public UITable table_tab;

	public CreateCharacterWidget CreateCharacterWidget;

	public SelectCharacterWidget SelectCharacterWidget;

	public CharacterModelView CharacterModelView;

	public GameObject btn_back;

	public Assets.Scripts.Ssar.CharacterSelection.View.CharacterInfo CharacterInfo;

	private CharacterSelectionTabView[] tabViews;

	private CharacterCode curTab;

	private int newCharId;

	protected override void Awake()
	{
	}

	private void BackToTitle(GameObject go)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show()
	{
	}

	private void UpdateTab()
	{
	}

	public void UpdateInfo()
	{
	}

	public void OnCreateCharacter(MainCharacterData mainCharacterData)
	{
	}

	public void OnDeleteCharacter(MainCharacterData mainCharacterData)
	{
	}

	private void SelectTab(CharacterCode tabType)
	{
	}

	private DisplayCharacterInfo GenerateDefaultCharacterInfo(int groupdId, int subId)
	{
		return null;
	}

	private void Init()
	{
	}

	private void UpdateTabText()
	{
	}

	private void InitTab()
	{
	}

	private CharacterCode GetTabSelect()
	{
		return default(CharacterCode);
	}
}
