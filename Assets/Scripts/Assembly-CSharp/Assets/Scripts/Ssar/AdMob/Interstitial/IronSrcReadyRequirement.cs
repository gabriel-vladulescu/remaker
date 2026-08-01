namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class IronSrcReadyRequirement : InterstitialAds.Requirement
	{
		private IronSrcSource ironSrcSource;

		public IronSrcReadyRequirement(IronSrcSource ironSrcSource)
		{
		}

		public void Touch()
		{
		}

		public bool IsMet()
		{
			return false;
		}

		public string Reason()
		{
			return null;
		}

		public void OnAdsShown()
		{
		}
	}
}
