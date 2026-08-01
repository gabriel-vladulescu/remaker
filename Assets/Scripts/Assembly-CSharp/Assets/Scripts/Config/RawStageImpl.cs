using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class RawStageImpl : RawStage
	{
		private Stage s;

		private List<RawGoal> rawGoals;

		private List<RawLosingCondition> rawLosingConditions;

		public RawStageImpl(Stage s)
		{
		}

		public int Id()
		{
			return 0;
		}

		public IEnumerable<RawGoal> Goals()
		{
			return null;
		}

		public IEnumerable<RawLosingCondition> LosingConditions()
		{
			return null;
		}
	}
}
