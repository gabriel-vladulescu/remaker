using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class MeleeAttackOnAirAction : AbsAction
	{
		private CharacterMediatorComponent characterMediatorComponent;

		private float t;

		private bool enableExit;

		private TimerAction timerAction;

		public MeleeAttackOnAirAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		private Direction GetDir()
		{
			return default(Direction);
		}
	}
}
