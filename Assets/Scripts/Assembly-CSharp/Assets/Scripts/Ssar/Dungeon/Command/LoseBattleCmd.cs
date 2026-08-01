using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class LoseBattleCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public DungeonLoseReason Reason { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
