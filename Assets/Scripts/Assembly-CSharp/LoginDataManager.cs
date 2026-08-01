using System;
using SSAR.Entry.Model;

public class LoginDataManager
{
	private FacebookLogin facebookLogin;

	private GuestLogin guestLogin;

	private GoogleLogin googleLogin;

	public void AutoSave(bool checkDevice = true)
	{
	}

	public void SignOut()
	{
	}

	public void LoginGuest(Action<bool, string> finish)
	{
	}

	public void LoginFacebook(Action<bool, string> finish)
	{
	}

	public void LoginGoogle(Action<bool, string> finish)
	{
	}
}
