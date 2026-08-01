using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class CheckEnterDuelArenaCmd : strange.extensions.command.impl.Command
	{
		private int rivalPower;

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void Enter(FindOpponentResult findOpponentResult)
		{
		}

		private void EnterMatchMetric(string arena)
		{
		}

		private void ModifyOpponentByTut(MainCharacterData mainCharacterData)
		{
		}
	}
}
