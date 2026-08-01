using Assets.Scripts.Utils;

public class ReportCrashInfo
{
	public string deviceId;

	public ExceptionInfo ExceptionInfo;

	public string version;

	public ReportCrashInfo(string deviceId, string version, ExceptionInfo exceptionInfo)
	{
	}

	public ReportCrashInfo()
	{
	}
}
