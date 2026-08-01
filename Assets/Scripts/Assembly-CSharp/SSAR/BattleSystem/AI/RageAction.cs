namespace SSAR.BattleSystem.AI
{
	public class RageAction : AbsAction
	{
		public RageAction(NewMonsterAIComponent aiComponent, ActionConfig config)
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
	}
}
