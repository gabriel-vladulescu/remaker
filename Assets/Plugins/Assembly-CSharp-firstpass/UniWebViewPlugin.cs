using UnityEngine;

public class UniWebViewPlugin
{
	private static AndroidJavaClass webView;

	public static void Init(string name, int top, int left, int bottom, int right)
	{
	}

	public static void ChangeInsets(string name, int top, int left, int bottom, int right)
	{
	}

	public static void Load(string name, string url)
	{
	}

	public static void LoadHTMLString(string name, string htmlString, string baseUrl)
	{
	}

	public static void Reload(string name)
	{
	}

	public static void Stop(string name)
	{
	}

	public static void EvaluatingJavaScript(string name, string javaScript)
	{
	}

	public static void AddJavaScript(string name, string javaScript)
	{
	}

	public static void Show(string name, bool fade, int direction, float duration)
	{
	}

	public static void Hide(string name, bool fade, int direction, float duration)
	{
	}

	public static void CleanCache(string name)
	{
	}

	public static void CleanCookie(string name, string key)
	{
	}

	public static void Destroy(string name)
	{
	}

	public static void SetSpinnerShowWhenLoading(string name, bool show)
	{
	}

	public static void SetSpinnerText(string name, string text)
	{
	}

	public static void TransparentBackground(string name, bool transparent)
	{
	}

	public static void SetBackgroundColor(string name, float r, float g, float b, float a)
	{
	}

	public static bool CanGoBack(string name)
	{
		return false;
	}

	public static bool CanGoForward(string name)
	{
		return false;
	}

	public static void GoBack(string name)
	{
	}

	public static void GoForward(string name)
	{
	}

	public static string GetCurrentUrl(string name)
	{
		return null;
	}

	public static void SetBackButtonEnable(string name, bool enable)
	{
	}

	public static void SetBounces(string name, bool enable)
	{
	}

	public static void SetZoomEnable(string name, bool enable)
	{
	}

	public static void AddUrlScheme(string name, string scheme)
	{
	}

	public static void RemoveUrlScheme(string name, string scheme)
	{
	}

	public static void SetUseWideViewPort(string name, bool use)
	{
	}

	public static void SetUserAgent(string userAgent)
	{
	}

	public static string GetUserAgent(string name)
	{
		return null;
	}

	public static float GetAlpha(string name)
	{
		return 0f;
	}

	public static void SetAlpha(string name, float alpha)
	{
	}

	public static void SetImmersiveModeEnabled(string name, bool enabled)
	{
	}

	public static void AddPermissionRequestTrustSite(string name, string url)
	{
	}

	public static void SetHeaderField(string name, string key, string value)
	{
	}

	public static void SetVerticalScrollBarShow(string name, bool show)
	{
	}

	public static void SetHorizontalScrollBarShow(string name, bool show)
	{
	}
}
