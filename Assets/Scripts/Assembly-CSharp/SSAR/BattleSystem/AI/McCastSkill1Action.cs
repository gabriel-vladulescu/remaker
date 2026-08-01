using SSAR.BattleSystem.Input;

namespace SSAR.BattleSystem.AI
{
	public class McCastSkill1Action : AbsAction
	{
		public bool changeDirectionToTarget;

		public int skillId;

		public float cooldownAllSkill;

		public string skillIdText;

		private bool flag;

		private int delayFrameRelease;

		private int frame;

		private float randomDuration;

		private bool hasReleaseInput;

		private bool available;

		private ActionType inputSkill;

		public McCastSkill1Action(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
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

		protected override bool IsExit()
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

		protected ActionType InPutSkill()
		{
			return default(ActionType);
		}

		private void ReleaseInputSkill()
		{
		}

		protected override void OnExit()
		{
		}
	}
}
