namespace Assets.Scripts.Core.UnlockableSystem.Cookies
{
	public class DefaultCookiesMatcher : CookiesMatcher
	{
		public bool Match(object[] propertyCookies, object[] metricCookies)
		{
			return false;
		}
	}
}
