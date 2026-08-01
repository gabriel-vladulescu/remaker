using Assets.Scripts.Ssar.Dungeon.Command;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public interface IOnBattleLoseLogic
	{
		void OnExcute(Metric metric, ConfigManager configManager, DungeonLoseReason reason);
	}
}
