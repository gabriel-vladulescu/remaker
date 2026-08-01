using System;

public class StreamVideoParameter
{
	public string filePathInStreamingAssets;

	public Action onFinish;

	public bool allowSkip;

	public bool loop;

	public bool autoHideOnfinish;

	public StreamVideoParameter(string filePathInStreamingAssets, Action onFinish, bool allowSkip, bool loop = false, bool autoHideOnFinish = true)
	{
	}
}
