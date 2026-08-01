using Assets.Scripts.Ssar.Dungeon.GameModeLogic;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class EndMatch : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private readonly BattleMode battleMode;

		private readonly string arena;

		private readonly int season;

		public bool IsLose { get; set; }

		public EndMatch(PlayerProgressionData playerProgressionData, BattleMode battleMode, string arena, int season)
		{
		}

		protected override void OnSend()
		{
		}
	}
}
