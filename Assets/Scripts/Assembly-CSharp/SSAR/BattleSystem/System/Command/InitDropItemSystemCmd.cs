using Assets.Scripts.Ssar.Command;
using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using strange.extensions.command.impl;

namespace SSAR.BattleSystem.System.Command
{
	public class InitDropItemSystemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Assets.Scripts.Ssar.Dungeon.Dungeon dungeon { get; set; }

		[Inject]
		public EquipmentGenerationConfig equipmentGenerationConfig { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}
	}
}
