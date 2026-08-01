using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Model;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena
{
	public class OnDuelArenaLoseLogic : IOnBattleLoseLogic
	{
		private ArenaModeParameter parameter;

		public OnDuelArenaLoseLogic(ArenaModeParameter parameter)
		{
		}

		public void OnExcute(Metric metric, ConfigManager configManager, DungeonLoseReason reason)
		{
		}
	}
}
