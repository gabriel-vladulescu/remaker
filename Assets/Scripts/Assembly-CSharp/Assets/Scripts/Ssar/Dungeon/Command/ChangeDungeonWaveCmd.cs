using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ChangeDungeonWaveCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int wave { get; set; }

		[Inject]
		public OnChangeDungeonWaveSignal OnChangeDungeonWaveSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
