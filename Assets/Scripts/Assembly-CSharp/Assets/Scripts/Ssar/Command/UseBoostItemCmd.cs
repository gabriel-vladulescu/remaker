using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class UseBoostItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BoostItemType BoostItemType { get; set; }

		public override void Execute()
		{
		}
	}
}
