using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Ssar.StarChest.View;
using Assets.Scripts.Ssar.WorldMap.View;
using Assets.Scripts.Utils;
using SSAR.View;
using SSAR.WorldMap.Model;
using Scripts.Config;
using UnityEngine;
using UnityEngine.SceneManagement;

// Real dungeon-page-with-levels screen (Resources/guiprefabs/worldmap/
// WorldmapPopup.prefab) - replaces the earlier SimpleDungeonSelectView
// placeholder now that the underlying rendering pipeline (shaders/fonts)
// is confirmed working. Scoped down the same way every other screen in
// this project has been: skill/equipment/rune/mastery buttons and the
// star/chest reward progress bar are monetization/progression-adjacent
// and stay inert (no real save data to drive them); node click skips the
// NodeInfoPopup interstitial and enters the dungeon directly; every node
// is treated as unlocked (no real save/progress system to base a lock
// state on). What's real: the actual 201-dungeon DungeonConfig.json data,
// the 4 real difficulty tabs, and left/right navigation across the 5 real
// maps.
public class WorldmapPopup : BasePopup
{
	public GameObject btn_left;

	public GameObject btn_right;

	public GameObject btn_skill;

	public GameObject btn_equipment;

	public GameObject btn_rune;

	public GameObject btn_mastery;

	public GameObject btn_quickplay;

	public WorldmapRegionView RegionView;

	public CurrentDifficultyView CurrentDifficultyView;

	public StarChestProgressContainer StarChestProgress;

	private UserResourcesView userResourcesView;

	private ShowWorldmapParameter parameter;

	private int currentMapId;

	private ScenarioDifficulty curDifficulty;

	private DungeonConfig cachedDungeonConfig;

	protected override void Awake()
	{
		base.Awake();
		if (btn_left != null)
		{
			UIEventListener.Get(btn_left).onClick += MoveLeft;
		}
		if (btn_right != null)
		{
			UIEventListener.Get(btn_right).onClick += MoveRight;
		}
		if (btn_quickplay != null)
		{
			UIEventListener.Get(btn_quickplay).onClick += GoToHighestDungeon;
		}
		if (RegionView != null)
		{
			RegionView.onNodeClick += EnterDungeon;
		}
		if (CurrentDifficultyView != null)
		{
			CurrentDifficultyView.OnDifficultySelected += ChangeDifficulty;
		}
		// Out of scope - same monetization/progression-adjacent buttons
		// left inert throughout this project (Main hub, etc.).
		if (btn_skill != null)
		{
			NGUITools.SetActive(btn_skill, false);
		}
		if (btn_equipment != null)
		{
			NGUITools.SetActive(btn_equipment, false);
		}
		if (btn_rune != null)
		{
			NGUITools.SetActive(btn_rune, false);
		}
		if (btn_mastery != null)
		{
			NGUITools.SetActive(btn_mastery, false);
		}
		if (StarChestProgress != null)
		{
			NGUITools.SetActive(StarChestProgress.gameObject, false);
		}
	}

	private void OnHidePopup(BasePopup obj, bool showAnotherPopup)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OpenMastery(GameObject go)
	{
	}

	protected override void onEnable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private void InitResources()
	{
	}

	public void Show(ShowWorldmapParameter parameter)
	{
		this.parameter = parameter;
		gameObject.SetActive(true);

		MapInfo firstMap = DungeonConfig().GetFirstMap();
		currentMapId = firstMap != null ? firstMap.id : 1;
		curDifficulty = ScenarioDifficulty.NORMAL;

		if (CurrentDifficultyView != null)
		{
			CurrentDifficultyView.Init(curDifficulty);
		}
		UpdateData(currentMapId, curDifficulty);
	}

	public void ChangeDifficulty(ScenarioDifficulty difficulty)
	{
		curDifficulty = difficulty;
		UpdateData(currentMapId, curDifficulty);
	}

	public void ReShow()
	{
		UpdateData(currentMapId, curDifficulty);
	}

	private void UpdateData(int mapId, ScenarioDifficulty scenarioDifficulty)
	{
		MapInfo mapInfo = DungeonConfig().GetMapInfo(mapId);
		if (RegionView != null && mapInfo != null)
		{
			RegionView.Show(mapInfo, scenarioDifficulty);
		}
		UpdateButtonNavigator(mapId);
	}

	private void MoveLeft(GameObject o)
	{
		if (currentMapId > 1)
		{
			currentMapId--;
			UpdateData(currentMapId, curDifficulty);
		}
	}

	private void MoveRight(GameObject o)
	{
		MapInfo highest = DungeonConfig().GetHighestMap();
		int maxMapId = highest != null ? highest.id : currentMapId;
		if (currentMapId < maxMapId)
		{
			currentMapId++;
			UpdateData(currentMapId, curDifficulty);
		}
	}

	private void GoToHighestDungeon(GameObject o)
	{
		int dungeonId = DungeonConfig().GetDungeonIdOfLastDungeonOfMap(currentMapId, curDifficulty);
		global::Scripts.Config.Dungeon dungeon = DungeonConfig().GetDungeonInfo(dungeonId);
		if (dungeon != null)
		{
			EnterDungeon(dungeon);
		}
	}

	private void EnterDungeon(global::Scripts.Config.Dungeon dungeon)
	{
		DungeonSelection.DungeonId = dungeon.id;
		SceneManager.LoadScene(SceneName.DUNGEON);
	}

	private void OpenSkillManager(GameObject o)
	{
	}

	private void OpenChest(GameObject o)
	{
	}

	private void OpenEquipment(GameObject o)
	{
	}

	private void CheckOpenNodeInfo(bool showInfo, int nodeId)
	{
	}

	private void UpdateButtonNavigator(int mapId)
	{
		if (btn_left != null)
		{
			NGUITools.SetActive(btn_left, mapId > 1);
		}
		if (btn_right != null)
		{
			MapInfo highest = DungeonConfig().GetHighestMap();
			int maxMapId = highest != null ? highest.id : mapId;
			NGUITools.SetActive(btn_right, mapId < maxMapId);
		}
	}

	private DungeonConfig DungeonConfig()
	{
		if (cachedDungeonConfig == null)
		{
			TextAsset json = Resources.Load<TextAsset>("config/DungeonConfig");
			cachedDungeonConfig = new DungeonConfig();
			if (json != null)
			{
				cachedDungeonConfig.OnMapValue(json.text);
			}
		}
		return cachedDungeonConfig;
	}

	private void CheckUnlockMastery()
	{
	}
}
