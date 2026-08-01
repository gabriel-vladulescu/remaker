using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class MoveForwardUpAction : AbsAction
	{
		public float verticalSpeed;

		private Direction dir;

		public MoveForwardUpAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		private Direction GetDir()
		{
			return default(Direction);
		}
	}
}
