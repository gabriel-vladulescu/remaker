using System.Collections.Generic;
using Assets.Scripts.Ssar.DailyLogin.View;
using UnityEngine;

public class DailyLoginPopup : BasePopup
{
	public UILabel lb_btnBonusReward;

	public TweenScale TweenScale;

	public GameObject btn_close;

	public UITable table_day;

	public UITable table_weekend;

	public UILabel lb_reset;

	public GameObject btn_reward;

	private ShowPopupNotifyParameter parameter;

	private List<DailyLoginDayView> all;

	private float time;

	private float DELAY;

	private GameObject fx;

	protected override void Awake()
	{
	}

	public void Show(ShowPopupNotifyParameter parameter)
	{
	}

	private void PlayTween()
	{
	}

	private void InitTable()
	{
	}

	public void UpdateData()
	{
	}

	public void UpdateButtonBonus()
	{
	}

	private void Update()
	{
	}

	private new void Hide(GameObject o)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void BonusReward(GameObject go)
	{
	}

	private bool HasClaimedBonusReward()
	{
		return false;
	}

	private DailyLoginData DailyLoginData()
	{
		return null;
	}
}
