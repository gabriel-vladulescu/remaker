using Assets.Scripts.Ssar.Dungeon.GameModeLogic;

namespace Ssar.Event.Xmas
{
	public class XmasWarQuest
	{
		public int id { get; set; }

		public string actionType { get; set; }

		public string mode { get; set; }

		public string difficulty { get; set; }

		public int basePoint { get; set; }

		public double bonusFactor { get; set; }

		public XmasWarQuestType warQuestType { get; private set; }

		public BattleMode battleMode { get; private set; }

		public ScenarioDifficulty scenarioDifficulty { get; private set; }

		public void MapValue()
		{
		}

		public static int Comparer(XmasWarQuest a, XmasWarQuest b)
		{
			return 0;
		}
	}
}
