using SSAR.BattleSystem.Input;

namespace SSAR.BattleSystem.AI
{
	public class CustomAction : AbsAction
	{
		public bool changeDirectionToTarget;

		public bool changeDirectionMoveLeftTarget;

		public ActionType actionType;

		public ActionType actionTypeExit;

		public CustomAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
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
	}
}
