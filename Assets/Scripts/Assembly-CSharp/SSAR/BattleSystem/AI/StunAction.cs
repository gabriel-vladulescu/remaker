namespace SSAR.BattleSystem.AI
{
	public class StunAction : AbsAction
	{
		public bool playFx;

		public float[] originalDuration;

		private float time;

		protected float randomDuration;

		public StunAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
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

		protected override void OnExit()
		{
		}

		private void ResetTime()
		{
		}
	}
}
