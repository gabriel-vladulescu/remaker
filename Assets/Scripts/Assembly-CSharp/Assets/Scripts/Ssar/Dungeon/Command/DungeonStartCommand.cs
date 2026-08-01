using Assets.Scripts.Ssar.Common.System;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DungeonStartCommand : strange.extensions.command.impl.Command
	{
		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem dungeonDefaultSystem { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem entryDefaultSystem { get; set; }

		[Inject]
		public FinishLoadDungeonSignal FinishLoadDungeonSignal { get; set; }

		[Inject]
		public DungeonSignalManager dungeonSignalManager { get; set; }

		public override void Execute()
		{
		}
	}
}
