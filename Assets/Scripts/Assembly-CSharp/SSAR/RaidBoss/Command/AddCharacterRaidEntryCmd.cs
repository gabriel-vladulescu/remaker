using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class AddCharacterRaidEntryCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int value { get; set; }

		public override void Execute()
		{
		}
	}
}
