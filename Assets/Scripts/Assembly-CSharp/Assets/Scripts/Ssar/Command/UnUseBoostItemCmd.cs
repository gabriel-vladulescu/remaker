using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class UnUseBoostItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BoostItemType type { get; set; }

		public override void Execute()
		{
		}
	}
}
