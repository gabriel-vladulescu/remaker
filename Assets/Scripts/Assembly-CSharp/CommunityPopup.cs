using UnityEngine;

public class CommunityPopup : BasePopup
{
	public GameObject btn_fanPage;

	public GameObject btn_group;

	public GameObject btn_discord;

	public GameObject btn_exit;

	protected override void Awake()
	{
	}

	public void Show()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}
}
