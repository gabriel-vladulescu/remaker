using UnityEngine;

public abstract class AbsQuestRowView : SimpleWraptContentRowView
{
	public UILabel lb_desc1;

	public UILabel lb_desc2;

	public UILabel lb_progress;

	public UILabel lb_rewardQuantity;

	public UIProgressBar ProgressBar;

	public UISprite sp_icon;

	public UISprite sp_rewardIcon;

	public GameObject wg_claimed;

	public GameObject btn_claim;

	public GameObject wg_reward;

	protected override void Awake()
	{
	}

	protected void Show()
	{
	}

	public override void Hide()
	{
	}

	protected abstract void ClickClaim(GameObject o);

	protected abstract bool HasClaimed();

	protected abstract bool CanClaim();

	protected abstract int QuestRequire();

	protected abstract int CurProgress();

	protected abstract ItemInfo RewardItemInfo();

	protected abstract string AchivementIcon();

	protected abstract string QuestName();

	protected abstract string QuestDesc();

	protected virtual bool DisableRewardWhenComplete()
	{
		return false;
	}

	protected virtual bool DisableProgressWhenComplete()
	{
		return false;
	}
}
