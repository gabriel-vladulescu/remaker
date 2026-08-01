using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class MixStageAdapter : Stage
	{
		private RawStage rawStage;

		private StageInspector stageInspector;

		private List<Goal> goals;

		private List<LosingCondition> losingConditions;

		private List<Challenge> challenges;

		private List<int> waveOrders;

		public MixStageAdapter(RawStage rawStage, StageInspector stageInspector)
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
