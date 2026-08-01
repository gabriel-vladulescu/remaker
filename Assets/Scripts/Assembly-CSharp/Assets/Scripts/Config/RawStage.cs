using System.Collections.Generic;

namespace Assets.Scripts.Config
{
	public interface RawStage
	{
		int Id();

		IEnumerable<RawGoal> Goals();

		IEnumerable<RawLosingCondition> LosingConditions();
	}
}
