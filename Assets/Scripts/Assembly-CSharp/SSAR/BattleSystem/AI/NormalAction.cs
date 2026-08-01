namespace SSAR.BattleSystem.AI
{
	public class NormalAction : AbsAction
	{
		public bool isPlayVictory;

		public NormalAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override bool IsEnable()
		{
			return false;
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

		public override bool IsRequireTarget()
		{
			return false;
		}
	}
}
