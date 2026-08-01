namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup5 : ITutorialGroup
	{
		private TutorialStage stageStart;

		private bool flag;

		public TutorialGroup5(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		private void ListenError(TutorialKey key, TutorialStage stage)
		{
		}

		private void EnterArenaPopup()
		{
		}

		private new void Complete()
		{
		}

		private void EnterDuel()
		{
		}

		public override bool Condition(TutorialKey fromKey)
		{
			return false;
		}

		private AbsCharacterDialogTutorialGroup5 Dialog()
		{
			return null;
		}

		public override bool IsErrorData()
		{
			return false;
		}
	}
}
