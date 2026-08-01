using Assets.Scripts.Ssar.Dungeon.Command;

namespace Scripts.Ssar.Arena
{
	public class DuelArenaStaticData
	{
		private int battleRandomSeed;

		private ArenaOpponentInfo opponentInfo;

		private SelectArenaRuneParameter selectArenaRuneParameter;

		public void SetRandomSeed(int randomSeed)
		{
		}

		public int GetRandomSeed()
		{
			return 0;
		}

		public void SetOpponent(ArenaOpponentInfo opponentInfo)
		{
		}

		public void SetArenaRune(SelectArenaRuneParameter parameter)
		{
		}

		public ArenaOpponentInfo GetArenaOpponentInfo()
		{
			return null;
		}

		public SelectArenaRuneParameter GetRuneParameter()
		{
			return null;
		}
	}
}
