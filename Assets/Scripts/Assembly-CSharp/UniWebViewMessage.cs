using System.Collections.Generic;

public struct UniWebViewMessage
{
	public string rawMessage { get; private set; }

	public string scheme { get; private set; }

	public string path { get; private set; }

	public Dictionary<string, string> args { get; private set; }

	public UniWebViewMessage(string rawMessage)
	{
		this.rawMessage = null;
		scheme = null;
		path = null;
		args = null;
	}
}
