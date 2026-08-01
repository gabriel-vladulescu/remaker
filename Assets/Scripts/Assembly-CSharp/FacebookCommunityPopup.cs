using Assets.Scripts.Ssar.Social.View;
using UnityEngine;

public class FacebookCommunityPopup : BasePopup
{
	public GameObject btn_close;

	public FacebookLikeContainer FacebookLikeContainer;

	public FacebookInviteContainer FacebookInviteContainer;

	public FacebookShareContainer FacebookShareContainer;

	public FacebookLoginContainer FacebookLoginContainer;

	private FacebookSocial social;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show()
	{
	}

	private void InitFacebook()
	{
	}
}
