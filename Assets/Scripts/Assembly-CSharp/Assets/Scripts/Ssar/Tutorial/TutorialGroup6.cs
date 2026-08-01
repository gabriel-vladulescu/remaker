namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup6 : ITutorialGroup
	{
		private TutorialStage _stage;

		public TutorialGroup6(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		private void AddComplete()
		{
		}

		public override bool Condition(TutorialKey fromKey)
		{
			return false;
		}

		public override bool IsCanInterrupt()
		{
			return false;
		}
	}
}
