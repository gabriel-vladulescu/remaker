using Assets.Scripts.Ssar.StarChest.View;
using Assets.Scripts.Ssar.WorldMap.View;
using SSAR.View;
using SSAR.WorldMap.Model;
using Scripts.Config;
using UnityEngine;

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

	protected override void Awake()
	{
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
	}

	public void ChangeDifficulty(ScenarioDifficulty difficulty)
	{
	}

	public void ReShow()
	{
	}

	private void UpdateData(int mapId, ScenarioDifficulty scenarioDifficulty)
	{
	}

	private void MoveLeft(GameObject o)
	{
	}

	private void MoveRight(GameObject o)
	{
	}

	private void GoToHighestDungeon(GameObject o)
	{
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
	}

	private DungeonConfig DungeonConfig()
	{
		return null;
	}

	private void CheckUnlockMastery()
	{
	}
}
