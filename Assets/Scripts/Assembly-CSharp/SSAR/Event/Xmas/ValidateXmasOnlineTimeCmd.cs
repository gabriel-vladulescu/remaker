using strange.extensions.command.impl;

namespace Ssar.Event.Xmas
{
	public class ValidateXmasOnlineTimeCmd : Command
	{
		[Inject]
		public MainCharacterData CharacterData { get; set; }

		public override void Execute()
		{
		}
	}
}
