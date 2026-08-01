namespace Ssar.RaidBoss.Model
{
	public class RaidBossSignalManager
	{
		[Inject]
		public EnterRaidBossSignal EnterRaidBossSignal { get; set; }

		[Inject]
		public ShowRaidPreparationPopupSignal ShowRaidPreparationPopupSignal { get; set; }

		[Inject]
		public CheckEnterRaidOfflineSignal CheckEnterRaidOfflineSignal { get; set; }

		[Inject]
		public CheckEnterRaidOnlineSignal CheckEnterRaidOnlineSignal { get; set; }

		[Inject]
		public FindRaidPartySignal FindRaidPartySignal { get; set; }

		[Inject]
		public ShowRaidFindPartyPopupSignal ShowRaidFindPartyPopupSignal { get; set; }

		[Inject]
		public ShowRaidSeasonalRewardPopupSignal ShowRaidSeasonalRewardPopupSignal { get; set; }

		[Inject]
		public ShowRaidUserInfoSignal ShowRaidUserInfoSignal { get; set; }

		[Inject]
		public GetRaidLeaderboardDataSignal GetRaidLeaderboardDataSignal { get; set; }

		[Inject]
		public ReshowRaidUserInfoPopupSignal ReshowRaidUserInfoPopupSignal { get; set; }

		[Inject]
		public CheckShowRaidPopupSignal CheckShowRaidPopupSignal { get; set; }

		[Inject]
		public ShowRaidStartNewSeasonPopupSignal ShowRaidStartNewSeasonPopupSignal { get; set; }

		[Inject]
		public ClaimRaidEndSeasonRewardSignal ClaimRaidEndSeasonRewardSignal { get; set; }

		[Inject]
		public UpdateRaidSeasonEndTimeSignal UpdateRaidSeasonEndTimeSignal { get; set; }

		[Inject]
		public LoadSeasonalRewardsStatusSignal LoadSeasonalRewardsStatusSignal { get; set; }

		[Inject]
		public LoadRaidRankDataSignal LoadRaidRankDataSignal { get; set; }

		[Inject]
		public LoadRaidGlobalProgressSignal LoadRaidGlobalProgressSignal { get; set; }

		[Inject]
		public ShowRaidGlobalRewardPopupSignal ShowRaidGlobalRewardPopupSignal { get; set; }

		[Inject]
		public OnLoadRaidGlobalProgressSuccessSignal OnLoadRaidGlobalProgressSuccessSignal { get; set; }

		[Inject]
		public LoadRaidGlobalRewardStatusSignal LoadRaidGlobalRewardStatusSignal { get; set; }

		[Inject]
		public ClaimRaidGlobalRewardSignal ClaimRaidGlobalRewardSignal { get; set; }

		[Inject]
		public AddCharacterRaidEntrySignal AddCharacterRaidEntrySignal { get; set; }

		[Inject]
		public UpdateRaidPersonalInfoViewSignal UpdateRaidPersonalInfoViewSignal { get; set; }

		[Inject]
		public LoadTestRaidSceneSignal LoadTestRaidSceneSignal { get; set; }
	}
}
