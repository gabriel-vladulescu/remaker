using Scripts.Ssar.Arena;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowArenaOpponentInfoPopupParameter
	{
		public string UserName { get; set; }

		public int Level { get; set; }

		public int Power { get; set; }

		public ArenaTier Tier { get; set; }

		public ArenaDivision Division { get; set; }

		public int Mmr { get; set; }

		public ShowArenaOpponentInfoPopupParameter(string userName, int level, int power, ArenaTier tier, ArenaDivision division, int mmr)
		{
		}
	}
}
