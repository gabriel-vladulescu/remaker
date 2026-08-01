using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitBattleFieldSystemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public RoutineRunner routineRunner { get; set; }

		[Inject]
		public IBattleModeLogic BattleMode { get; set; }

		public override void Execute()
		{
		}

		private Assets.Scripts.Ssar.Dungeon.Configs.DungeonConfig GetDungeonConfig()
		{
			return null;
		}
	}
}
