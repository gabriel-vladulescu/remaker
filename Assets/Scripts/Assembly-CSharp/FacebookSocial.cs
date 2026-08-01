using System;
using System.Collections.Generic;
using Facebook.Unity;

public class FacebookSocial : ISocial
{
	private class FacebookAppRequestReponse
	{
		public string request;

		public string to;

		public string[] GetUserIdsInvited()
		{
			return null;
		}
	}

	private class LoginResultParse
	{
		public string user_id { get; set; }

		public string access_token { get; set; }
	}

	private string _likeUrlProtocol;

	private string likeUrl;

	private string inviteMessage;

	private string shareUrl;

	private string groupAppUrl;

	private string groupWebUrl;

	public string userId;

	public string facebookToken => null;

	public FacebookSocial(string likeUrlProtocol, string likeUrl, string groupAppUrl, string groupWebUrl, string inviteMessage, string shareUrl)
	{
	}

	public void Init(Action<bool> callBack)
	{
	}

	public void SendEventIap(float price, string currency, Dictionary<string, object> parameter)
	{
	}

	public void Login(Action success, Action<string> error)
	{
	}

	public void Like(Action success, Action<string> error)
	{
	}

	public void Share(Action success, Action<string> error)
	{
	}

	public void Invite(Action<string[]> success, Action<string> error)
	{
	}

	private void Process(IResult result, Action success, Action<string> error)
	{
	}

	public void JoinGroup(Action success, Action<string> error)
	{
	}
}
