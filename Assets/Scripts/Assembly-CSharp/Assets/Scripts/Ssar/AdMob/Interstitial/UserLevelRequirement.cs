namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class UserLevelRequirement : InterstitialAds.Requirement
	{
		private int[] levelRange;

		private MainCharacterData mcd;

		public UserLevelRequirement(int[] levelRange, MainCharacterData mcd)
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
