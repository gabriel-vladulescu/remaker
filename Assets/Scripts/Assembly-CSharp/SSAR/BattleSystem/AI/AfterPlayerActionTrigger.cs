namespace SSAR.BattleSystem.AI
{
	public class AfterPlayerActionTrigger : AbsTrigger
	{
		public EntityAction entityAction;

		public float rate;

		public float pointDeduct;

		private bool hasRegister;

		public AfterPlayerActionTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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

		private void Register()
		{
		}

		private void CallBack(EntityAction enAction)
		{
		}
	}
}
