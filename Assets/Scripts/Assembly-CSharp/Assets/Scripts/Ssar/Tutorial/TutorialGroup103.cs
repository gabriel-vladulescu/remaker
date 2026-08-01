namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup103 : ITutorialGroup
	{
		public override bool IsComplete => false;

		public TutorialGroup103(string name, MainCharacterData mainCharacterData)
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
