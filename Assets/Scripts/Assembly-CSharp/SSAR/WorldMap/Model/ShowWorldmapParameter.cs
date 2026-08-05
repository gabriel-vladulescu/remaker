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
			this.type = type;
			this.showInfo = showInfo;
			this.specificNodeId = specificNodeId;
			this.enableInterstitialAds = enableInterstitialAds;
			nodeTarget = GenerateNodeTarget();
		}

		public int GetNodeTarget()
		{
			return nodeTarget;
		}

		public bool ShowInfo()
		{
			return showInfo;
		}

		private int GenerateNodeTarget()
		{
			return type == ShowWorldMapType.SpecificNode ? specificNodeId : 0;
		}
	}
}
