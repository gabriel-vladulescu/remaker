using Artemis;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class UpdateArcaneFormRemainingDurationCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Entity Entity { get; set; }

		[Inject]
		public float remainingTime { get; set; }

		public override void Execute()
		{
		}
	}
}
