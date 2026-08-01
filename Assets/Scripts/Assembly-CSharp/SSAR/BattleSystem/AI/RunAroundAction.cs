using Artemis;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class RunAroundAction : AbsAction
	{
		private Direction direction;

		public RunAroundAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnExcute()
		{
		}

		private Direction GetMoveLeftDirection(Entity self, Entity target)
		{
			return default(Direction);
		}

		private Direction ApproachDirection(Entity self, Entity target)
		{
			return default(Direction);
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}
	}
}
