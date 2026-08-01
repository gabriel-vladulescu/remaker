using UnityEngine;

public class DailyRewardItemView : MonoBehaviour
{
	public UILabel lb_name;

	public UISprite sp_icon;

	public GameObject wg_canClaim;

	public GameObject wg_claimed;

	public virtual void Show(DailyRewardInfo info)
	{
	}

	public void SetClaimMark(bool canClaim)
	{
	}

	public void SetTick(bool claimed)
	{
	}

	public virtual void Hide()
	{
	}
}
