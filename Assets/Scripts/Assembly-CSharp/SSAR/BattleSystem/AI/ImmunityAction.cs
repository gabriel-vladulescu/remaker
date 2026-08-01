namespace SSAR.BattleSystem.AI
{
	public class ImmunityAction : AbsAction
	{
		public float[] originalDuration;

		private float time;

		public ImmunityAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
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
	}
}
