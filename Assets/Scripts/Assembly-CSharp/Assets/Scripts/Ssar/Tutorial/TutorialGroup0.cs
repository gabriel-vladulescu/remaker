namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup0 : ITutorialGroup
	{
		public TutorialGroup0(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		public override bool Condition(TutorialKey fromKey)
		{
			return false;
		}
	}
}
