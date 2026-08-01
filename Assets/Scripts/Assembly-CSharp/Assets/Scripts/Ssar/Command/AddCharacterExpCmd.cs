using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class AddCharacterExpCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int value { get; set; }

		public override void Execute()
		{
		}
	}
}
