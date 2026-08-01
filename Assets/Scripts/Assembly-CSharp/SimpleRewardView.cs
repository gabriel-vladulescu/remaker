using UnityEngine;

public class SimpleRewardView : MonoBehaviour
{
	public UISprite sp_rarity;

	public UISprite sp_icon;

	public UILabel lb_name;

	public UILabel lb_quantity;

	public UILabel lb_tier;

	public UISprite[] skillIcon;

	public GameObject wg_tier;

	private ItemInfo ItemInfo;

	public void Show(ItemInfo itemInfo)
	{
	}

	public void Hide()
	{
	}
}
