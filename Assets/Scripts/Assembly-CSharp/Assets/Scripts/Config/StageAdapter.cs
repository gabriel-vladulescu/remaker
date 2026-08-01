using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class StageAdapter : Stage
	{
		private RawStage rawStage;

		public StageAdapter(RawStage rawStage)
		{
		}

		public int Id()
		{
			return 0;
		}

		public IEnumerable<Goal> GoalList()
		{
			return null;
		}

		public IEnumerable<LosingCondition> LosingConditionList()
		{
			return null;
		}

		public IEnumerable<Challenge> ChallengeList()
		{
			return null;
		}

		public int WaveCount()
		{
			return 0;
		}
	}
}
