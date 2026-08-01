namespace SSAR.BattleSystem.AI
{
	public class AfterTargetCastSkillTrigger : AbsTrigger
	{
		public string skillId;

		public float rate;

		public float pointDeduct;

		public AfterTargetCastSkillTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}
	}
}
