using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class DashLeftTargetAction : AbsAction
	{
		public float distanceToEdgeChangeDirection;

		public bool approachTarget;

		public float rateApproach;

		public float[] originalDuration;

		private bool fixDirection;

		private Direction overrideDirection;

		private DashEvadeSkillLogic dashEvadeSkillLogic;

		public DashLeftTargetAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		public void SetDirection(Direction direction)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override bool IsEnable()
		{
			return false;
		}

		public override bool AwakeCondition()
		{
			return false;
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
	}
}
