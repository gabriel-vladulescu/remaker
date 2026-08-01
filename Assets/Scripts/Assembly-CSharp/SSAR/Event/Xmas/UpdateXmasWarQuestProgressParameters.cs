using Assets.Scripts.Ssar.Dungeon.GameModeLogic;

namespace Ssar.Event.Xmas
{
	public class UpdateXmasWarQuestProgressParameters
	{
		public XmasWarQuestType type;

		public BattleMode mode;

		public ScenarioDifficulty difficulty;

		public int baseCount;

		public int bonusCount;

		public UpdateXmasWarQuestProgressParameters(XmasWarQuestType type, BattleMode mode, ScenarioDifficulty difficulty, int baseCount = 1, int bonusCount = 0)
		{
		}
	}
}
