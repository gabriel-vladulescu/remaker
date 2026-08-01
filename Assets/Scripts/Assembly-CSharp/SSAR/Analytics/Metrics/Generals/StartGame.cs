using Scripts.Config;

namespace Ssar.Analytics.Metrics.Generals
{
	public class StartGame
	{
		public enum StartGameSources
		{
			Icon = 0,
			Notification = 1
		}

		private GeneralData generalData;

		private readonly StartGameSources source;

		private readonly CharacterName characterName;

		public StartGame(GeneralData generalData, StartGameSources source, CharacterName characterName)
		{
		}

		public void Send()
		{
		}
	}
}
