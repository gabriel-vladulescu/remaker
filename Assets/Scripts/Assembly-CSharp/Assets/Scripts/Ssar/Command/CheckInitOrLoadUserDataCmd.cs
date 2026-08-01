using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class CheckInitOrLoadUserDataCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void CheckAndLoadLocal()
		{
		}

		private void SendMetric()
		{
		}

		private void Init()
		{
		}

		private void SetUserData(UserData userData)
		{
		}

		private bool HasUserData()
		{
			return false;
		}
	}
}
