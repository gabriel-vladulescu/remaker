namespace Assets.Scripts.Core.Scheduling
{
	public class ViewClockTimeObserver
	{
		public ClockTimeObserver Observer { get; private set; }

		public float TickSize { get; private set; }

		public float Accumulator { get; set; }

		public ViewClockTimeObserver(ClockTimeObserver observer, float tickSize, float accumulator)
		{
		}
	}
}
