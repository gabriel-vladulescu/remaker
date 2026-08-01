using UnityEngine;

public class RewardReceiveView : MonoBehaviour
{
	public UILabel lb_name;

	public UILabel lb_leftTop;

	public UILabel lb_rightTop;

	public UILabel lb_tier;

	public UISprite sp_rarity;

	public UISprite sp_icon;

	public GameObject wg_tier;

	public GameObject bg2;

	public GameObject wgTick;

	private UISprite sp_bg;

	private bool disableBgAndQuality;

	private void Awake()
	{
	}

	public void EnableBg2()
	{
	}

	public void Show(ItemInfo itemInfo)
	{
	}

	public void Hide()
	{
	}

	public void EnableBgAndQuality(bool enable)
	{
	}

	public void EnableWgTick(bool enable)
	{
	}
}
