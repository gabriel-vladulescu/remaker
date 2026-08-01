using Assets.Scripts.Ssar.Dungeon.GameModeLogic;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class StartMatch
	{
		private PlayerProgressionData playerProgressionData;

		private readonly BattleMode battleMode;

		private readonly string arena;

		private readonly int season;

		public StartMatch(PlayerProgressionData playerProgressionData, BattleMode battleMode, string arena, int season)
		{
		}

		public void Send()
		{
		}
	}
}
