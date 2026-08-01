using Assets.Scripts.Ssar.Common.System;
using SSAR.BattleSystem.System;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ClearBattleFieldCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public DungeonFrameTimeSubcribe DungeonFrameTimeSubcribe { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem entryDefaultSystem { get; set; }

		public override void Execute()
		{
		}
	}
}
