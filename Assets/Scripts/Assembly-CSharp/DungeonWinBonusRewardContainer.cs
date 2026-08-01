using Assets.Scripts.Ssar.Dungeon;
using SSAR.Dungeon.Model;
using UnityEngine;

public class DungeonWinBonusRewardContainer : MonoBehaviour
{
	public DungeonWinButtonX2 btn_exp;

	public DungeonWinButtonX2 btn_soul;

	public GameObject btn_equipment;

	public UISprite sp_icon;

	public UISprite sp_quality;

	public UILabel lb_name;

	public GameObject notify;

	private DungeonWinParameter parameter;

	private void Awake()
	{
	}

	public void Show(DungeonWinParameter parameter)
	{
	}

	public void Hide()
	{
	}

	public void HideButton(BonusItemType itemType)
	{
	}

	private void AddExp(GameObject o)
	{
	}

	private void AddSoul(GameObject o)
	{
	}

	private void RandomEquipment(GameObject o)
	{
	}
}
