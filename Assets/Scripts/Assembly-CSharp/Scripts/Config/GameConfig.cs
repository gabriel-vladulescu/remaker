namespace Scripts.Config
{
	public class GameConfig
	{
		public static readonly int[] DISPLAY_NAME_LENGHT;

		public string highestDungeonPlayable { get; set; }

		public string highestDungeonUnlockWhenInit { get; set; }

		public int resurrectionCost { get; set; }

		public int maxSkillPointCanPurchase { get; set; }

		public int crystalPerSkillPoint { get; set; }

		public double bonusExpGainTicketValue { get; set; }

		public double bonusSoulGainTicketvalue { get; set; }

		public double hpPotionValue { get; set; }

		public double hpPotionCooldown { get; set; }

		public int shopVendorResetTimeInSecond { get; set; }

		public int initExpTicket { get; set; }

		public int initSoulTicket { get; set; }

		public int initAutoTicket { get; set; }

		public int initHpPotion { get; set; }

		public string firebaseDatabaseUrl { get; set; }

		public string firebaseDatabaseUrlOfRaid { get; set; }

		public int hellModeMaxTombstone { get; set; }

		public int loadDataCooldown { get; set; }

		public string firebaseStorageUrl { get; set; }

		public int firebaseStorageMaxAllowedSize { get; set; }

		public int[] bonusExpFromWatchVodRate { get; set; }

		public int[] bonusSoulFromWatchVodRate { get; set; }

		public string crossPromotionUrl { get; set; }

		public double ironSourceVideoRewardHitRate { get; set; }

		public double intervalAutoSaveToCloud { get; set; }

		public double intervalSaveToCloud { get; set; }

		public string configFolderUrl { get; set; }

		public bool enableSelectLanguageWhenInit { get; set; }

		public string arenaCurrentTimeInMillis { get; set; }

		public string arenaJoinSeason { get; set; }

		public string arenaFindOpponent { get; set; }

		public string arenaUpdateDuelResult { get; set; }

		public string arenaGetUserMmrRank { get; set; }

		public string arenaGetLeaderboard { get; set; }

		public string arenaGetClaimReward { get; set; }

		public string arenaGetCurrentSeasonInfo { get; set; }

		public string arenaGetUserSeasonProgress { get; set; }

		public string arenaGetPreviousSeasonId { get; set; }

		public string arenaGetUserSeasonProgressesAndRewardStatus { get; set; }

		public string arenaGetDivisionLeaderboard { get; set; }

		public string raidGetLeaderboard { get; set; }

		public string raidGetRank { get; set; }

		public string raidGetUpdateBattleResult { get; set; }

		public string raidGetSeasonData { get; set; }

		public string raidFindParty { get; set; }

		public string raidGetUserProgress { get; set; }

		public string raidJoinSeason { get; set; }

		public int GetBonusExpFromWatchVodRate(int watchTimes)
		{
			return 0;
		}

		public int GetBonusSoulFromWatchVodRate(int watchTimes)
		{
			return 0;
		}

		private int GetValueFromArray(int[] array, int watchTimes)
		{
			return 0;
		}
	}
}
