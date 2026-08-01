using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.Dungeon.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class WatchVodGainBonusItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BonusItemType BonusItemType { get; set; }

		[Inject]
		public DungeonWinParameter DungeonWinParameter { get; set; }

		[Inject]
		public AddBonusExpFromWatchVodSignal AddBonusExpFromWatchVodSignal { get; set; }

		[Inject]
		public AddBonusSoulFromWatchVodSignal AddBonusSoulFromWatchVodSignal { get; set; }

		[Inject]
		public AddEquipmentFromWatchVodSignal AddEquipmentFromWatchVodSignal { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private void RegenerateItem()
		{
		}

		public static ItemInfo FindEquipmentHighest(DungeonWinParameter winParameter)
		{
			return null;
		}
	}
}
