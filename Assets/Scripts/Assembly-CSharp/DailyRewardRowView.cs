using UnityEngine;

public class DailyRewardRowView : MonoBehaviour
{
	[SerializeField]
	private GameObject btn_watchAds;

	[SerializeField]
	private UILabel lb_title;

	[SerializeField]
	private UILabel lb_watchAds;

	[SerializeField]
	private UISprite sp_watchAds;

	[SerializeField]
	private DailyRewardItemView[] rewardItemViews;

	[SerializeField]
	private Color enableColor;

	[SerializeField]
	private Color disableColor;

	private DailyRewardInfo[] rewardInfos;

	private bool canClaim;

	private int rowIndex;

	private ButtonCollider buttonCollider;

	private void Awake()
	{
	}

	private void OnWatchAds(GameObject go)
	{
	}

	public void Init(DailyRewardInfo[] info, int rowIndex)
	{
	}

	public void Show()
	{
	}

	public void Hide(bool claimed)
	{
	}

	public void Claimed()
	{
	}

	private void SetButtonClaimClickable(bool clickable)
	{
	}
}
