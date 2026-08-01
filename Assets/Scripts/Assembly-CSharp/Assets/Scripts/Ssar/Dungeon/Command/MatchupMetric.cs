using Assets.Scripts.Ssar.CharacterSelection.Model;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class MatchupMetric
	{
		private Metric metric;

		private CharacterCode main;

		private CharacterCode opponent;

		private string winnerName;

		private int seasonalCode;

		public MatchupMetric(Metric metric, CharacterCode main, CharacterCode opponent, string winnerName, int seasonalCode)
		{
		}

		public void Send()
		{
		}
	}
}
