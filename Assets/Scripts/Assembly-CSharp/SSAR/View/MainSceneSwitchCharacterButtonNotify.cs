namespace SSAR.View
{
	public class MainSceneSwitchCharacterButtonNotify : AbsButtonNofity
	{
		private bool en;

		protected override void Awake()
		{
		}

		private bool HasCreateCharacter(int groupId)
		{
			return false;
		}

		protected override bool IsNotify()
		{
			return false;
		}
	}
}
