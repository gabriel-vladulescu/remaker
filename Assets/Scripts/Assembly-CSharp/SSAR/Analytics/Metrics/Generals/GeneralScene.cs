using Ssar.Analytics.Metrics.PlayerProgressions;

namespace Ssar.Analytics.Metrics.Generals
{
	public class GeneralScene : DurationMetric
	{
		private readonly PlayerProgressionData playerProgressionData;

		private readonly string arena;

		private readonly string previousLocation;

		public string PreviousLocation => null;

		public string Location { get; set; }

		public GeneralScene(PlayerProgressionData playerProgressionData, string previousLocation, string arena)
		{
		}

		protected override void OnSend()
		{
		}
	}
}
