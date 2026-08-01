using Scripts.Ssar.Arena;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class ShowDuelArenaWinParameter
	{
		public ArenaTier TierBefore { get; set; }

		public int Division { get; set; }

		public int StarReceived { get; set; }

		public ShowDuelArenaWinParameter(ArenaTier tierBefore, int division, int starReceived)
		{
		}
	}
}
