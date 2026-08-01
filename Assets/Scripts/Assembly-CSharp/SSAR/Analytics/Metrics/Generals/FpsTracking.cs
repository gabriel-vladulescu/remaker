using Ssar.Analytics.Metrics.PlayerProgressions;

namespace Ssar.Analytics.Metrics.Generals
{
	public class FpsTracking
	{
		private PlayerProgressionData playerData;

		private readonly int minFps;

		private readonly int maxFps;

		private readonly int below10Fps;

		private readonly int below20Fps;

		public FpsTracking(PlayerProgressionData playerData, int minFps, int maxFps, int below10Fps, int below20Fps)
		{
		}

		public void Send()
		{
		}
	}
}
