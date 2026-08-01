namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup7 : ITutorialGroup
	{
		public TutorialGroup7(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		private void AddComplete(TutorialKey key, TutorialStage stage)
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
