namespace SSAR.BattleSystem.AI
{
	public class FortifyAction : AbsAction
	{
		public FortifyAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override bool IsEnable()
		{
			return false;
		}

		protected override bool IsExit()
		{
			return false;
		}

		protected override void OnExit()
		{
		}

		public override bool IsRequireTarget()
		{
			return false;
		}
	}
}
