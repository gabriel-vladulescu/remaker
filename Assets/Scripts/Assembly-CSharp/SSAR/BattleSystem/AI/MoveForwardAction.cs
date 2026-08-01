namespace SSAR.BattleSystem.AI
{
	public class MoveForwardAction : AbsAction
	{
		public bool changeDirectionOneTime;

		public float[] range;

		protected float moveTime;

		public float[] originalDuration;

		protected float randomRange;

		protected float randomDuration;

		private float minRange;

		private int dir;

		public MoveForwardAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		private bool IsInSkillState()
		{
			return false;
		}

		protected override bool IsEnable()
		{
			return false;
		}

		public override bool AwakeCondition()
		{
			return false;
		}

		protected virtual bool CheckMinRangeToEnable()
		{
			return false;
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

		protected override void OnExit()
		{
		}

		protected bool IsEndDuration()
		{
			return false;
		}

		protected virtual bool ExitCondition()
		{
			return false;
		}

		protected virtual bool EnableCondition()
		{
			return false;
		}

		private int GetDir()
		{
			return 0;
		}
	}
}
