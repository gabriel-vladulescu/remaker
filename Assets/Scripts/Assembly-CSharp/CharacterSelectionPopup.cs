using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.CharacterSelection.View;
using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Ssar.Worldmap.View;
using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	// Deviation from the original stub: the real roster system (create,
	// select, delete multiple MainCharacterData instances, persisted via
	// BayatGames SaveGameFree, which is itself still stub) is a large,
	// not-yet-reimplemented subsystem. Since RealCharacterValidationHarness
	// already proved the group_1/1_1 character spawns/moves/animates
	// correctly through the real production spawn path, this popup uses
	// that known-good character directly instead of a real roster - same
	// "scope down to the validated path" rationale as MainSceneBootstrap
	// only wiring btn_adventure out of Main's ~40 buttons.
	private SimpleDungeonSelectView dungeonSelectView;

	private GameObject buttonTemplate;

	private GameObject labelTemplate;

	protected override void Awake()
	{
		// Clone real, already-styled NGUI widgets from this scene (real
		// atlas/font/collider setup, not guessed) while everything is
		// still active/findable, and park them outside this popup's own
		// hierarchy so hiding this popup later doesn't take them with it.
		// SimpleDungeonSelectView uses these as building blocks for its
		// dungeon list instead of constructing raw NGUI widgets blind.
		GameObject btnSource = GameObject.Find("btn_try");
		GameObject lblSource = GameObject.Find("lb_title");
		if (btnSource != null)
		{
			buttonTemplate = Instantiate(btnSource, transform.parent, worldPositionStays: false);
			buttonTemplate.name = "DungeonRowButtonTemplate";
			buttonTemplate.SetActive(false);
		}
		if (lblSource != null)
		{
			labelTemplate = Instantiate(lblSource, transform.parent, worldPositionStays: false);
			labelTemplate.name = "DungeonRowLabelTemplate";
			labelTemplate.SetActive(false);
		}

		if (btn_back != null)
		{
			UIEventListener.Get(btn_back).onClick += BackToTitle;
		}
		if (CreateCharacterWidget != null)
		{
			CreateCharacterWidget.gameObject.SetActive(false);
		}
		if (SelectCharacterWidget != null)
		{
			SelectCharacterWidget.OnStart += OnCharacterStart;
			MainCharacterData defaultCharacter = new MainCharacterData(DungeonSelection.HeroGroupId)
			{
				groupId = DungeonSelection.HeroGroupId,
				subId = DungeonSelection.HeroSubId,
				level = DungeonSelection.HeroLevel,
				displayName = "Hero"
			};
			SelectCharacterWidget.Show(defaultCharacter);
		}
	}

	private void BackToTitle(GameObject go)
	{
		SceneManager.LoadScene(SceneName.MAIN);
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
		gameObject.SetActive(true);
	}

	private void OnCharacterStart(MainCharacterData mainCharacterData)
	{
		if (mainCharacterData != null)
		{
			DungeonSelection.HeroGroupId = mainCharacterData.groupId;
			DungeonSelection.HeroSubId = mainCharacterData.subId;
			DungeonSelection.HeroLevel = Mathf.Max(1, mainCharacterData.level);
		}
		gameObject.SetActive(false);
		if (dungeonSelectView == null)
		{
			GameObject go = new GameObject("SimpleDungeonSelectView (not part of the original game)");
			go.transform.SetParent(transform.parent, worldPositionStays: false);
			dungeonSelectView = go.AddComponent<SimpleDungeonSelectView>();
			dungeonSelectView.Init(buttonTemplate, labelTemplate);
			dungeonSelectView.OnBack += ShowAgain;
		}
		dungeonSelectView.Show();
	}

	private void ShowAgain()
	{
		Show();
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
