namespace Scripts.Config
{
	public class Stage
	{
		public int id;

		public string[] goals;

		public string[] losingConditions;

		public int[] challengeIds;

		private Goal[] processedGoals;

		private LosingCondition[] processedLosingConditions;

		public void ProcessGoals()
		{
		}

		public void ProcessLosingConditions()
		{
		}

		public Goal[] Goals()
		{
			return null;
		}

		public LosingCondition[] LosingConditions()
		{
			return null;
		}
	}
}
