using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class DashAttackAction : AbsAction
	{
		public bool enableJump;

		public float hasTargetInRangeX;

		public float hasTargetInRangeY;

		private float delayDash;

		private float delayAttack;

		private float delayExit;

		private bool hasDash;

		private bool enableExit;

		private bool hasJump;

		private float timeReleaseDash;

		private Direction direction;

		private TimerAction timerReleasejump;

		public DashAttackAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		protected override void OnExit()
		{
		}

		private Direction GetDir()
		{
			return default(Direction);
		}

		private bool TargetInRangeX()
		{
			return false;
		}

		private bool TargetInRangeY()
		{
			return false;
		}

		private bool TargetIsInAir()
		{
			return false;
		}
	}
}
