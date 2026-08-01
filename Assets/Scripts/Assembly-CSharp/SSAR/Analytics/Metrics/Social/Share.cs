namespace Ssar.Analytics.Metrics.Social
{
	public class Share
	{
		public enum SharingSource
		{
			Link = 0,
			ItemDetail = 1,
			Open10 = 2,
			HeroDetail = 3,
			LevelUp = 4
		}

		private readonly SocialData socialData;

		private SharingSource sharingSource;

		public Share(SocialData socialData, SharingSource sharingSource)
		{
		}

		public void Send()
		{
		}
	}
}
