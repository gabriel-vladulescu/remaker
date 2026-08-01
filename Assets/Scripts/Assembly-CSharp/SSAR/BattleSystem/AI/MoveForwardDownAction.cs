using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class MoveForwardDownAction : AbsAction
	{
		public float verticalSpeed;

		public bool changeDirectionOneTime;

		public float[] rangeX;

		public float offsetPositionTargetHead;

		private Direction dir;

		private float randomRange;

		public MoveForwardDownAction(NewMonsterAIComponent aiComponent, ActionConfig config)
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
