namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup102 : ITutorialGroup
	{
		public override bool IsComplete => false;

		public TutorialGroup102(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		public override bool IsErrorData()
		{
			return false;
		}

		public override bool IsCanInterrupt()
		{
			return false;
		}

		public override bool IsAlwayCheckError()
		{
			return false;
		}
	}
}
