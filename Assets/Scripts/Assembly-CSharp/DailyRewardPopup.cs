using Assets.Scripts.Ssar.DataManager;
using UnityEngine;

public class DailyRewardPopup : BasePopup
{
	public GameObject btn_close;

	public DailyRewardRowView firstRow;

	public DailyRewardRowView secondRow;

	public DailyRewardRowView thirdRow;

	private FreeEquipmentData freeEquipmentData;

	protected override void Awake()
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

	public void UpdateData()
	{
	}

	private bool CanWatchAds(int lastTimeClaim)
	{
		return false;
	}
}
