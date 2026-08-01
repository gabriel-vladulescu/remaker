using System.Collections.Generic;

public class WaitResponseManager
{
	private class WaitResponseParameter
	{
		public bool instance;

		public float minTimeToShow;

		public WaitResponseParameter(bool instance = false, float minTimeToShow = 0.2f)
		{
		}
	}

	private Dictionary<string, WaitResponseParameter> extensionResponseSignals;

	private List<string> queue;

	public static readonly string GIFT_CODE;

	public static readonly string LOAD_CLOUD_DATA;

	public static readonly string ARENA_API;

	private void AddCmdID(string cmdID, WaitResponseParameter parameter = null)
	{
	}

	public void OnSendRequest(string cmdId)
	{
	}

	public void OnServerResponse(string cmdId)
	{
	}
}
