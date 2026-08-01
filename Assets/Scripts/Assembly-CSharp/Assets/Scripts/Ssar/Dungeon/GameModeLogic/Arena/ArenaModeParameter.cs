using Scripts.Ssar.Arena;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena
{
	public class ArenaModeParameter
	{
		public MainCharacterData leftData;

		public MainCharacterData rightData;

		public ArenaTier ArenaTier;

		public ArenaReplayData ArenaReplayData;

		public ArenaDivision ArenaDivision { get; set; }

		public int rank { get; set; }

		public string OpponentId { get; set; }

		public ArenaModeParameter(MainCharacterData leftData, MainCharacterData rightData, ArenaTier arenaTier, ArenaDivision arenaDivision, int rank, string opponentId)
		{
		}

		public ArenaModeParameter Replay(ArenaReplayData arenaReplayData)
		{
			return null;
		}

		public bool IsReplay()
		{
			return false;
		}
	}
}
