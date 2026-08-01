using Scripts.Config;
using UnityEngine;

public class EventItemView : MonoBehaviour
{
	public UILabel lb_value;

	public UISprite sp_icon;

	public GameObject wg_claimed;

	public virtual void Show(MoreThanCrystalReward info)
	{
	}

	public void SetClaim(bool claimed)
	{
	}

	public virtual void Hide()
	{
	}
}
