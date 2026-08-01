namespace Ssar.Analytics.Metrics.Generals
{
	public class SetCharacterName : DurationMetric
	{
		private GeneralData generalData;

		private string name;

		public GeneralData GeneralData
		{
			set
			{
			}
		}

		public string Name
		{
			set
			{
			}
		}

		public SetCharacterName(GeneralData generalData, string name)
		{
		}

		public SetCharacterName()
		{
		}

		protected override void OnSend()
		{
		}
	}
}
