namespace SSAR.BattleSystem.AI
{
	public class FuryAction : AbsAction
	{
		public FuryAction(NewMonsterAIComponent aiComponent, ActionConfig config)
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

		public override bool IsRequireTarget()
		{
			return false;
		}
	}
}
