using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ReceiveX2ItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public List<ItemInfo> ItemInfos { get; set; }

		[Inject]
		public OnReceiveX2ItemSignal OnReceiveX2ItemSignal { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}
	}
}
