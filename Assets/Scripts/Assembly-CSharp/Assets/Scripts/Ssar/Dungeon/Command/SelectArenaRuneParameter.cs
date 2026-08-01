using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SelectArenaRuneParameter
	{
		public ArenaRuneInfo allianecRune;

		public ArenaRuneInfo enemyRune;

		public SelectArenaRuneParameter(ArenaRuneInfo allianceRune, ArenaRuneInfo enemyRune = null)
		{
		}

		public SelectArenaRuneParameter()
		{
		}
	}
}
