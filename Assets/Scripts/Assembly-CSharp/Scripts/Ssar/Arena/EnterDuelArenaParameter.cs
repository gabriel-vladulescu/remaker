namespace Scripts.Ssar.Arena
{
	public class EnterDuelArenaParameter
	{
		public ArenaTier mainTier;

		public MainCharacterData OpponentData { get; set; }

		public ArenaTier Tier { get; set; }

		public ArenaDivision Division { get; set; }

		public int rank { get; set; }

		public string OpponentId { get; set; }

		public EnterDuelArenaParameter(MainCharacterData opponentData, ArenaTier tier, ArenaDivision division, int rank, string opponentId, ArenaTier mainTier)
		{
		}
	}
}
