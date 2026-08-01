using Artemis;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ChangeToArcaneFormCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Entity Entity { get; set; }

		public override void Execute()
		{
		}
	}
}
