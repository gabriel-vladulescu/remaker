using System;

public interface ISocial
{
	void Init(Action<bool> callBack);

	void Login(Action success, Action<string> error);

	void Like(Action success, Action<string> error);

	void Share(Action success, Action<string> error);

	void Invite(Action<string[]> success, Action<string> error);

	void JoinGroup(Action success, Action<string> error);
}
