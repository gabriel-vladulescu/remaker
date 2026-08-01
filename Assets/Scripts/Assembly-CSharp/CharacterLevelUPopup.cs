using SSAR.LevelUp.View;
using UnityEngine;

public class CharacterLevelUPopup : BasePopup
{
	public UILabel lb_level;

	public UILabel lb_attackTitle;

	public UILabel lb_defTitle;

	public UILabel lb_hpTitle;

	public UILabel lb_skillUnlocked;

	public UILabel lb_attackBefore;

	public UILabel lb_defBefore;

	public UILabel lb_hpBefore;

	public UILabel lb_attackAfter;

	public UILabel lb_defAfter;

	public UILabel lb_hpAfter;

	public CharacterLevelUpRewardView[] RewardViews;

	public UITable table_reward;

	public TweenScale TweenScale;

	public GameObject btn_mask;

	public UIWidget Widget;

	private bool finishFx;

	private ShowPopupNotifyParameter parameter;

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

	public void Show(ShowPopupNotifyParameter parameter)
	{
	}

	private void UpdateData()
	{
	}

	private void Stat(int levelBefore, int levelAfter)
	{
	}

	private void Reward(int levelBefore, int levelAfter)
	{
	}

	private void PlayTween()
	{
	}

	private void Click(GameObject o)
	{
	}
}
