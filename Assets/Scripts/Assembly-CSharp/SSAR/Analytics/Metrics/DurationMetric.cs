namespace Ssar.Analytics.Metrics
{
	public abstract class DurationMetric
	{
		private float start;

		private float end;

		private bool finish;

		public void StartTrack(float currentTime)
		{
		}

		public void EndTrack(float currentTime)
		{
		}

		public bool IsTracking()
		{
			return false;
		}

		public float Duration()
		{
			return 0f;
		}

		public void Send()
		{
		}

		protected abstract void OnSend();

		private void Log(string s)
		{
		}
	}
}
