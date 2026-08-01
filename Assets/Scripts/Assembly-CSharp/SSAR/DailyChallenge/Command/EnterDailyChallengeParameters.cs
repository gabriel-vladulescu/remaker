using Scripts.Config;

namespace Ssar.DailyChallenge.Command
{
	public class EnterDailyChallengeParameters
	{
		public DailyChallengeConfig.Dungeon dungeon;

		public MainCharacterData mainCharacterData;

		public int[] roundIds;

		public EnterDailyChallengeParameters(DailyChallengeConfig.Dungeon dungeon, MainCharacterData mainCharacterData, int[] roundIds)
		{
		}
	}
}
