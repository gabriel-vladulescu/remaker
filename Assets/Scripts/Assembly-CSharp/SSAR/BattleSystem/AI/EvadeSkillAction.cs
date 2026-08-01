namespace SSAR.BattleSystem.AI
{
	public class EvadeSkillAction : AbsAction
	{
		public float[] originalDuration;

		public bool disableApproachTarget;

		private AbsEvadeSkillLogic logic;

		private string skillId;

		public EvadeSkillAction(NewMonsterAIComponent aiComponent, ActionConfig config)
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

		protected override void OnExit()
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		public AbsEvadeSkillLogic GeneratEvadeSkillLogic()
		{
			return null;
		}
	}
}
