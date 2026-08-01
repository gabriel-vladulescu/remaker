namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class IapRequirement : InterstitialAds.Requirement
	{
		private UserData userData;

		public IapRequirement(UserData userData)
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
