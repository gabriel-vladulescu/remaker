using SSAR.BattleSystem.Input;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class CastSkill1Action : AbsAction
	{
		public bool checkisInFrontOf;

		public float hasTargetInRangeX;

		public float cooldownAllSkill;

		private bool flag;

		private int delayFrameRelease;

		private int frame;

		private float randomDuration;

		private bool hasReleaseInput;

		public CastSkill1Action(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		public override bool AwakeCondition()
		{
			return false;
		}

		private bool IsInSkillState()
		{
			return false;
		}

		private bool IsInRangeX()
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

		protected virtual ActionType InPutSkill()
		{
			return default(ActionType);
		}

		protected virtual int SkillConfigOrder()
		{
			return 0;
		}

		private void ReleaseInputSkill()
		{
		}

		private bool CheckIsInFrontOfValid()
		{
			return false;
		}

		private bool IsTargetInFrontOf()
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
	}
}
