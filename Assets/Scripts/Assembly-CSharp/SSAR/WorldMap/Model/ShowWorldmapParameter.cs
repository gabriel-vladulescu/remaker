using SSAR.WorldMap.Enum;

namespace SSAR.WorldMap.Model
{
	public class ShowWorldmapParameter
	{
		private ShowWorldMapType type;

		private bool showInfo;

		private int nodeTarget;

		private int specificNodeId;

		private bool enableInterstitialAds;

		public bool EnableInterstitialAds => false;

		public ShowWorldmapParameter(ShowWorldMapType type, bool showInfo, int specificNodeId = 0, bool enableInterstitialAds = false)
		{
		}

		public int GetNodeTarget()
		{
			return 0;
		}

		public bool ShowInfo()
		{
			return false;
		}

		private int GenerateNodeTarget()
		{
			return 0;
		}
	}
}
