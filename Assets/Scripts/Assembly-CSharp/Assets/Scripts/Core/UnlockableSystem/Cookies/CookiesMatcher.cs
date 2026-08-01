namespace Assets.Scripts.Core.UnlockableSystem.Cookies
{
	public interface CookiesMatcher
	{
		bool Match(object[] propertyCookies, object[] metricCookies);
	}
}
