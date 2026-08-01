using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface Stage
	{
		int Id();

		IEnumerable<Goal> GoalList();

		IEnumerable<LosingCondition> LosingConditionList();

		IEnumerable<Challenge> ChallengeList();

		int WaveCount();
	}
}
