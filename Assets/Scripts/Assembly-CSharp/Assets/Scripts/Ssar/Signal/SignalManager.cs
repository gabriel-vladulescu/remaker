using Assets.Scripts.Ssar.Dungeon.Signal;
using Assets.Scripts.Ssar.Iap.Command;
using Ssar.Event.SevenDaysCampaign.Model;
using Ssar.Giftcodes.Commands;

namespace Assets.Scripts.Ssar.Signal
{
	public class SignalManager
	{
		[Inject]
		public LoadDungeonSignal LoadDungeonSignal { get; set; }

		[Inject]
		public LoadTestAISceneSignal LoadTestAiSceneSignal { get; set; }

		[Inject]
		public LoadStartSceneSignal LoadStartSceneSignal { get; set; }

		[Inject]
		public ShowErrorPopupSignal ShowErrorPopupSignal { get; set; }

		[Inject]
		public ShowWorldmapPopupSignal ShowWorldmapPopupSignal { get; set; }

		[Inject]
		public ShowNodeInfoPopupSignal ShowNodeInfoPopupSignal { get; set; }

		[Inject]
		public ShowSkillTreePopupSignal ShowSkillTreePopupSignal { get; set; }

		[Inject]
		public ShowEquipmentPopupSignal ShowEquipmentPopupSignal { get; set; }

		[Inject]
		public CheckEnterNodeSignal CheckEnterNodeSignal { get; set; }

		[Inject]
		public CheckAndLoadMainSceneSignal CheckAndLoadMainSceneSignal { get; set; }

		[Inject]
		public ShowMainScenePopupSignal ShowMainScenePopupSignal { get; set; }

		[Inject]
		public LoadTestDungeonSceneSignal LoadTestDungeonSceneSignal { get; set; }

		[Inject]
		public AddCharacterSoulSignal AddCharacterSoulSignal { get; set; }

		[Inject]
		public AddCharacterExpSignal AddCharacterExpSignal { get; set; }

		[Inject]
		public ShowBlackMaskPopupSignal ShowBlackMaskPopupSignal { get; set; }

		[Inject]
		public HideBlackMaskPopupSignal HideBlackMaskPopupSignal { get; set; }

		[Inject]
		public ScaleGameTimeSignal ScaleGameTimeSignal { get; set; }

		[Inject]
		public ChangeEquipmentInventoryTabSignal ChangeEquipmentInventoryTabSignal { get; set; }

		[Inject]
		public ReshowWorldMapSignal ReshowWorldMapSignal { get; set; }

		[Inject]
		public ShowInventorySignal ShowInventorySignal { get; set; }

		[Inject]
		public ShowConfirmPopupSignal ShowConfirmPopupSignal { get; set; }

		[Inject]
		public ShowArenaRankRewardConfirmPopupSignal ShowArenaRankRewardConfirmPopupSignal { get; set; }

		[Inject]
		public ShowItemComparerPopupSignal ShowItemComparerPopupSignal { get; set; }

		[Inject]
		public ShowPreviewPopupInShopSignal ShowPreviewPopupInShopSignal { get; set; }

		[Inject]
		public EquipEquipmentSignal EquipEquipmentSignal { get; set; }

		[Inject]
		public UnEquipEquipmentSignal UnEquipEquipmentSignal { get; set; }

		[Inject]
		public OnEquipEquipmentSuccessSignal OnEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnUnequipEquipmentSuccessSignal OnUnequipEquipmentSuccessSignal { get; set; }

		[Inject]
		public LockEquipmentSignal LockEquipmentSignal { get; set; }

		[Inject]
		public OnLockEquipmentSuccessSignal OnLockEquipmentSuccessSignal { get; set; }

		[Inject]
		public UnlockEquipmentSignal UnlockEquipmentSignal { get; set; }

		[Inject]
		public OnUnlockEquipmentSuccessSignal OnUnlockEquipmentSuccessSignal { get; set; }

		[Inject]
		public AutoEquipEquipmentSignal AutoEquipEquipmentSignal { get; set; }

		[Inject]
		public OnAutoEquipEquipmentSuccessSignal OnAutoEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public ShowAutoEquipEquipmentPopupSignal ShowAutoEquipEquipmentPopupSignal { get; set; }

		[Inject]
		public EnhanceEquipmentSignal EnhanceEquipmentSignal { get; set; }

		[Inject]
		public OnEnhanceEquipmentSuccessSignal OnEnhanceEquipmentSuccessSignal { get; set; }

		[Inject]
		public ConsumeSoulSignal ConsumeSoulSignal { get; set; }

		[Inject]
		public ConsumeCrystalSignal ConsumeCrystalSignal { get; set; }

		[Inject]
		public SellOneEquipmentSignal SellOneEquipmentSignal { get; set; }

		[Inject]
		public SellAllEquipmentSignal SellAllEquipmentSignal { get; set; }

		[Inject]
		public OnSellOneEquipmentSuccessSignal OnSellOneEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnSellAllEquipmentSuccessSignal OnSellAllEquipmentSuccessSignal { get; set; }

		[Inject]
		public ShowSellAllEquipmentPopupSignal ShowSellAllEquipmentPopupSignal { get; set; }

		[Inject]
		public ShowInventoryExpandPopupSignal ShowInventoryExpandPopupSignal { get; set; }

		[Inject]
		public ExpandInventorySignal ExpandInventorySignal { get; set; }

		[Inject]
		public OnExpandInventorySuccessSignal OnExpandInventorySuccessSignal { get; set; }

		[Inject]
		public ShowCharacterStatDetailSignal ShowCharacterStatDetailSignal { get; set; }

		[Inject]
		public HideCharacterStatDetailSignal HideCharacterStatDetailSignal { get; set; }

		[Inject]
		public CharacterLevelUpSignal CharacterLevelUpSignal { get; set; }

		[Inject]
		public ShowConfirmWithTitlePopupSignal ShowConfirmWithTitlePopupSignal { get; set; }

		[Inject]
		public ShowTooltipPopupSignal ShowTooltipPopupSignal { get; set; }

		[Inject]
		public ShowBlockInputPopupSignal ShowBlockInputPopupSignal { get; set; }

		[Inject]
		public HideBlockInputPopupSignal HideBlockInputPopupSignal { get; set; }

		[Inject]
		public ShowCharacterLevelUpPopupSignal ShowCharacterLevelUpPopupSignal { get; set; }

		[Inject]
		public AddRewardFromItemInfoSignal AddRewardFromItemInfoSignal { get; set; }

		[Inject]
		public AddCharacterCrystalSignal AddCharacterCrystalSignal { get; set; }

		[Inject]
		public AddCharacterStaminaSignal AddCharacterStaminaSignal { get; set; }

		[Inject]
		public AddCharacterArenaKeySignal AddCharacterArenaKeySignal { get; set; }

		[Inject]
		public ShowRewardReceivePopupSignal ShowRewardReceivePopupSignal { get; set; }

		[Inject]
		public ShowEquipmentPreviewPopupSignal ShowEquipmentPreviewPopupSignal { get; set; }

		[Inject]
		public ShowSettingPopupSignal ShowSettingPopupSignal { get; set; }

		[Inject]
		public ShowContactUsPopupSignal ShowContactUsPopupSignal { get; set; }

		[Inject]
		public ShowCommunityPopupSignal ShowCommunityPopupSignal { get; set; }

		[Inject]
		public ShowChangeDisplayNamePopupSignal ShowChangeDisplayNamePopupSignal { get; set; }

		[Inject]
		public ChangeDisplayNameSignal ChangeDisplayNameSignal { get; set; }

		[Inject]
		public ShowGiftCodePopupSignal ShowGiftCodePopupSignal { get; set; }

		[Inject]
		public UseGiftCodeSignal UseGiftCodeSignal { get; set; }

		[Inject]
		public OpenRandomEquipmentTicketSignal OpenRandomEquipmentTicketSignal { get; set; }

		[Inject]
		public ShowMultiRewardReceivePopupSignal ShowMultiRewardReceivePopupSignal { get; set; }

		[Inject]
		public ChangeScenarioDifficultySignal ChangeScenarioDifficultySignal { get; set; }

		[Inject]
		public OpenStarChestSignal OpenStarChestSignal { get; set; }

		[Inject]
		public OnOpenStarChestSuccessSignal OnOpenStarChestSuccessSignal { get; set; }

		[Inject]
		public ShowStarChestRewardPopupSignal ShowStarChestRewardPopupSignal { get; set; }

		[Inject]
		public ShowWaitingResponsePopupSignal ShowWaitingResponsePopupSignal { get; set; }

		[Inject]
		public EnableEquipmentVisualSignal EnableEquipmentVisualSignal { get; set; }

		[Inject]
		public DisableEquipmentVisualSignal DisableEquipmentVisualSignal { get; set; }

		[Inject]
		public ShowEquipmentSkillInfoPopupSignal ShowEquipmentSkillInfoPopupSignal { get; set; }

		[Inject]
		public EnterDungeonSignal EnterDungeonSignal { get; set; }

		[Inject]
		public ShowViewVideoAdsPopupSignal ShowViewVideoAdsPopupSignal { get; set; }

		[Inject]
		public EnterBloodyTowerSignal EnterBloodyTowerSignal { get; set; }

		[Inject]
		public ClaimDuelArenaParticipateRewardSignal ClaimDuelArenaParticipateRewardSignal { get; set; }

		[Inject]
		public ShowSkillInfoPopupSignal ShowSkillInfoPopupSignal { get; set; }

		[Inject]
		public ShowBannerPopupSignal ShowBannerPopupSignal { get; set; }

		[Inject]
		public AddCharacterVideoTicketSignal AddCharacterVideoTicketSignal { get; set; }

		[Inject]
		public ShowDeathPenaltyWarningPopupSignal ShowDeathPenaltyWarningPopupSignal { get; set; }

		[Inject]
		public ShowDungeonDeathPenaltyPopupSignal ShowDungeonDeathPenaltyPopupSignal { get; set; }

		[Inject]
		public UpdateDisplayDamageTextSignal UpdateDisplayDamageTextSignal { get; set; }

		[Inject]
		public ShowSkillManagerPopupSignal ShowSkillManagerPopupSignal { get; set; }

		[Inject]
		public AddCharacterSkillPointSignal AddCharacterSkillPointSignal { get; set; }

		[Inject]
		public OnPurchaseSkillPointSuccessSignal OnPurchaseSkillPointSuccessSignal { get; set; }

		[Inject]
		public ShowPurchaseSkillPointPopupSignal ShowPurchaseSkillPointPopupSignal { get; set; }

		[Inject]
		public PurchaseSkillPointSignal PurchaseSkillPointSignal { get; set; }

		[Inject]
		public InvestSkillPointToRuneOfActiveSkillSignal InvestSkillPointToRuneOfActiveSkillSignal { get; set; }

		[Inject]
		public DivestSkillPointFromRuneOfActiveSkillSigSnal DivestSkillPointFromRuneOfActiveSkillSignal { get; set; }

		[Inject]
		public ShowSwapSkillPopupSignal ShowSwapSkillPopup { get; set; }

		[Inject]
		public InvestSkillPointToSignatureSkillSignal InvestSkillPointToSignatureSkillSignal { get; set; }

		[Inject]
		public DivestSkillPointFromSignatureSkillSignal DivestSkillPointFromSignatureSkillSignal { get; set; }

		[Inject]
		public InvestSkillPointToPassiveSkillSignal InvestSkillPointToPassiveSkillSignal { get; set; }

		[Inject]
		public DivestSkillPointFromPassiveSkillSignal DivestSkillPointFromPassiveSkillSignal { get; set; }

		[Inject]
		public SaveCharacterSkillDataSignal SaveCharacterSkillDataSignal { get; set; }

		[Inject]
		public ShowNewSkillUnlockNotifyPopupSignal ShowNewSkillUnlockNotifyPopupSignal { get; set; }

		[Inject]
		public OnSwapSkillSignal OnSwapSkillSignal { get; set; }

		[Inject]
		public BuyDoubleExpPackageSignal BuyDoubleExpPackageSignal { get; set; }

		[Inject]
		public ShowControlLayoutPopupSignal ShowControlLayoutPopupSignal { get; set; }

		[Inject]
		public ChangeControllerLayoutSignal ChangeControllerLayoutSignal { get; set; }

		[Inject]
		public ShowPvpSkillGuidePopupSignal ShowPvpSkillGuidePopupSignal { get; set; }

		[Inject]
		public UseBoostItemSignal UseBoostItemSignal { get; set; }

		[Inject]
		public UnUseBoostItemSignal UnUseBoostItemSignal { get; set; }

		[Inject]
		public ShowDailyLoginPopupSignal ShowDailyLoginPopupSignal { get; set; }

		[Inject]
		public ClaimDailyLoginRewardSignal ClaimDailyLoginRewardSignal { get; set; }

		[Inject]
		public OnClaimDailyLoginRewardSuccessSignal OnClaimDailyLoginRewardSuccessSignal { get; set; }

		[Inject]
		public ClaimDailyLoginBonusRewardSignal ClaimDailyLoginBonusRewardSignal { get; set; }

		[Inject]
		public ShowAllAncientPackageSignal ShowAllAncientPackageSignal { get; set; }

		[Inject]
		public OnClaimDailyRewardSuccessSignal OnClaimDailyRewardSuccessSignal { get; set; }

		[Inject]
		public ShowDailyRewardPopupSignal ShowDailyRewardPopupSignal { get; set; }

		[Inject]
		public ClaimDailyRewardSignal ClaimDailyRewardSignal { get; set; }

		[Inject]
		public ShowShopPopupSignal ShowShopPopupSignal { get; set; }

		[Inject]
		public BuyCrystalSignal BuyCrystalSignal { get; set; }

		[Inject]
		public BuySoulSignal BuySoulSignal { get; set; }

		[Inject]
		public BuyStaminaSignal BuyStaminaSignal { get; set; }

		[Inject]
		public BuySpecialItemSignal BuySpecialItemSignal { get; set; }

		[Inject]
		public BuyPackageSignal BuyPackageSignal { get; set; }

		[Inject]
		public BuyTreasureSignal BuyTreasureSignal { get; set; }

		[Inject]
		public OnBuySoulSuccessSignal OnBuySoulSuccessSignal { get; set; }

		[Inject]
		public OnBuyCrystalSuccessSignal OnBuyCrystalSuccessSignal { get; set; }

		[Inject]
		public OnBuyStaminaSuccessSignal OnBuyStaminaSuccessSignal { get; set; }

		[Inject]
		public OnBuySpecialItemSuccessSignal OnBuySpecialItemSuccessSignal { get; set; }

		[Inject]
		public OnBuyPackageSuccessSignal OnBuyPackageSuccessSignal { get; set; }

		[Inject]
		public OnBuyTreasureSuccessSignal OnBuyTreasureSuccessSignal { get; set; }

		[Inject]
		public ShowShopTreasureChestFxPopupSignal ShowShopTreasureChestFxPopupSignal { get; set; }

		[Inject]
		public ShowShopTreasureBoughtSuccessPopupSignal ShowShopTreasureBoughtSuccessPopupSignal { get; set; }

		[Inject]
		public ShowShopVendorPopupSignal ShowShopVendorPopupSignal { get; set; }

		[Inject]
		public ShowShopBlackFridaySalePopupSignal ShowShopBlackFridaySalePopupSignal { get; set; }

		[Inject]
		public ShowShopTreasurePopupSignal ShowShopTreasurePopupSignal { get; set; }

		[Inject]
		public CheckAndConsumeResourcesToPurchaseSignal CheckAndConsumeResourcesToPurchaseSignal { get; set; }

		[Inject]
		public ShowShopPurchaseConfirmPopupSignal ShowShopPurchaseConfirmPopupSignal { get; set; }

		[Inject]
		public BuyShopVendorItemSignal BuyShopVendorItemSignal { get; set; }

		[Inject]
		public BuyShopBlackFridayItemSignal BuyShopBlackFridayItemSignal { get; set; }

		[Inject]
		public OnBuyShopVendorItemSuccessSignal OnBuyShopVendorItemSuccessSignal { get; set; }

		[Inject]
		public OnBuyShopBlackFridayItemSuccessSignal OnBuyShopBlackFridayItemSuccessSignal { get; set; }

		[Inject]
		public OnBuyShopBlackFridayPackSuccessSignal OnBuyShopBlackFridayPackSuccessSignal { get; set; }

		[Inject]
		public OnBuyShopBlackFridaySaleItemSuccessSignal OnBuyShopBlackFridaySaleItemSuccessSignal { get; set; }

		[Inject]
		public SaveShopVendorDataSignal SaveShopVendorDataSignal { get; set; }

		[Inject]
		public RefreshShopVendorSignal RefreshShopVendorSignal { get; set; }

		[Inject]
		public OnRefreshShopVendorSuccessSignal OnRefreshShopVendorSuccessSignal { get; set; }

		[Inject]
		public ShowShopVendorRefreshConfirmPopupSignal ShowShopVendorRefreshConfirmPopupSignal { get; set; }

		[Inject]
		public ShowLevelUpPackagePopupSignal ShowLevelUpPackageRewardPopupSignal { get; set; }

		[Inject]
		public BuyLevelUpPackageSignal BuyLevelUpPackageSignal { get; set; }

		[Inject]
		public OnBuyLevelUpPackageSuccessSignal OnBuyLevelUpPackageSuccessSignal { get; set; }

		[Inject]
		public ClaimRewardAtLevelOfLevelUpPackageSignal ClaimRewardAtLevelOfLevelUpPackageSignal { get; set; }

		[Inject]
		public OnClaimRewardOfLevelUpPackageSuccessSiggnal OnClaimRewardOfLevelUpPackageSuccessSiggnal { get; set; }

		[Inject]
		public ShowSubscribePackagePopupSignal ShowSubscribePackagePopupSignal { get; set; }

		[Inject]
		public BuySubscriptionPackageSignal BuySubscriptionPackageSignal { get; set; }

		[Inject]
		public BuySubscriptionPackageSuccessSignal BuySubscriptionPackageSuccessSignal { get; set; }

		[Inject]
		public OnBuySubscriptionPackageSuccessSignal OnBuySubscriptionPackageSuccessSignal { get; set; }

		[Inject]
		public ClaimSubscriptionPackageRewardSignal ClaimSubscriptionPackageRewardSignal { get; set; }

		[Inject]
		public OnClaimSubscriptionPackageRewardSuccessSignal OnClaimSubscriptionPackageRewardSuccessSignal { get; set; }

		[Inject]
		public ShowBundlePackageOneProductPopupSignal ShowBundlePackageOneProductPopupSignal { get; set; }

		[Inject]
		public BuyBundlePackageSignal BuyBundlePackageSignal { get; set; }

		[Inject]
		public BuyBundlePackageFailureSignal BuyBundlePackageFailureSignal { get; set; }

		[Inject]
		public BuyBundlePackageSuccessSignal BuyBundlePackageSuccessSignal { get; set; }

		[Inject]
		public OnBuyBundlePackageSuccessSignal OnBuyBundlePackageSuccessSignal { get; set; }

		[Inject]
		public ShowBundlePackageAllProductPopupSignal ShowBundlePackageThreeProductPopupSignal { get; set; }

		[Inject]
		public ShowFirstTimePurchasePopupSignal ShowFirstTimePurchasePopupSignal { get; set; }

		[Inject]
		public BuyFirstTopUpPackageSuccessSignal BuyFirstTopUpPackageSuccessSignal { get; set; }

		[Inject]
		public ShowNewLevelUpPackageCategoryPopupSignal ShowNewLevelUpPackageCategoryPopupSignal { get; set; }

		[Inject]
		public BuyLevelUpPackageSuccessSignal BuyLevelUpPackageSuccessSignal { get; set; }

		[Inject]
		public ShowNewSubscribePackageCategoryPopupSignal ShowNewSubscribePackageCategoryPopupSignal { get; set; }

		[Inject]
		public BuyFirstTopUpPackageSignal BuyFirstTopUpPackageSignal { get; set; }

		[Inject]
		public ShowPiggyBankPopupSignal ShowPiggyBankPopupSignal { get; set; }

		[Inject]
		public BuyPiggyBankSignal BuyPiggyBankSignal { get; set; }

		[Inject]
		public BuyPiggyBankSuccessSignal BuyPiggyBankSuccessSignal { get; set; }

		[Inject]
		public ShowAllRunePackageSignal ShowAllRunePackageSignal { get; set; }

		[Inject]
		public ShowAllPetSignal ShowAllPetSignal { get; set; }

		[Inject]
		public ShowDoubleExpPackagePopupSignal ShowDoubleExpPackagePopupSignal { get; set; }

		[Inject]
		public ShowFlashSaleEventPopupSignal ShowFlashSaleEventPopupSignal { get; set; }

		[Inject]
		public BuyFlashSaleItemSuccessSignal BuyFlashSaleItemSuccessSignal { get; set; }

		[Inject]
		public BuyFlashSaleItemSignal BuyFlashSaleItemSignal { get; set; }

		[Inject]
		public OnPurchaseResultSignal onPurchaseResultSignal { get; set; }

		[Inject]
		public BuyFreeSubscriptionPackageSignal BuyFreeSubscriptionPackageSignal { get; set; }

		[Inject]
		public ShowUnlockAllCharactersPopupSignal ShowUnlockAllCharactersPopupSignal { get; set; }

		[Inject]
		public BuyAllCharactersSignal BuyAllCharactersSignal { get; set; }

		[Inject]
		public ShowFlashSaleOreRuneBundleSignal ShowFlashSaleOreRuneBundleSignal { get; set; }

		[Inject]
		public BuyFlashSaleOreRuneBundleSignal BuyFlashSaleOreRuneBundleSignal { get; set; }

		[Inject]
		public ShowAchievementPopupSignal ShowAchievementPopupSignal { get; set; }

		[Inject]
		public UpdateAchievementPopupSignal UpdateAchievementPopupSignal { get; set; }

		[Inject]
		public ClaimAchievementSignal ClaimAchievementSignal { get; set; }

		[Inject]
		public ShowAchievementUnlockNotifyPopupSignal ShowAchievementUnlockNotifyPopupSignal { get; set; }

		[Inject]
		public SendLikeFacebookSignal SendLikeFacebookSignal { get; set; }

		[Inject]
		public OnLikedFacebookSuccessSignal OnLikedFacebookSuccessSignal { get; set; }

		[Inject]
		public SendInvitedFacebookSignal SendInvitedFacebookSignal { get; set; }

		[Inject]
		public OnInviteFacebookSuccessSignal OnInviteFacebookSuccessSignal { get; set; }

		[Inject]
		public SendJoinFacebookSignal SendJoinFacebookSignal { get; set; }

		[Inject]
		public OnJoinFacebookSuccessSignal OnJoinFacebookSuccessSignal { get; set; }

		[Inject]
		public ShareFacebookSuccessSIgnal ShareFacebookSuccessSIgnal { get; set; }

		[Inject]
		public OnShareFacebookSuccessSignal OnShareFacebookSuccessSignal { get; set; }

		[Inject]
		public LoadTitleSceneSignal LoadTitleSceneSignal { get; set; }

		[Inject]
		public TapToPlaySignal TapToPlaySignal { get; set; }

		[Inject]
		public TutorialCameraBlurSignal TutorialCameraBlurSignal { get; set; }

		[Inject]
		public CompleteTutorialSignal CompleteTutorialSignal { get; set; }

		[Inject]
		public AddCompleteTutorialRewardSignal AddCompleteTutorialRewardSignal { get; set; }

		[Inject]
		public ShowFacebookDataSelectionPopupSignal ShowFacebookDataSelectionPopupSignal { get; set; }

		[Inject]
		public SendTutorialPrepareDataSignal SendTutorialPrepareDataSignal { get; set; }

		[Inject]
		public ShowStreamVideoPopupSignal ShowStreamVideoPopupSignal { get; set; }

		[Inject]
		public ShowChangeLanguagePopupSignal ShowChangeLanguagePopupSignal { get; set; }

		[Inject]
		public ShowChestPopupSignal ShowChestPopupSignal { get; set; }

		[Inject]
		public ShowConfirmWithSoulPopupSignal ShowConfirmWithSoulPopupSignal { get; set; }

		[Inject]
		public ShowChallengeMapPopupSignal ShowChallengeMapPopupSignal { get; set; }

		[Inject]
		public ShowBloodyTowerPopupSignal ShowBloodyTowerPopupSignal { get; set; }

		[Inject]
		public LoadTestAIPrepareSceneSignal LoadTestAiPrepareSceneSignal { get; set; }

		[Inject]
		public CheckEnterBloodyTowerFloorSignal CheckEnterBloodyTowerFloorSignal { get; set; }

		[Inject]
		public ShowNotifyUnlockNewFeatureSignal ShowNotifyUnlockNewFeatureSignal { get; set; }

		[Inject]
		public ValidateUserDataSignal ValidateUserDataSignal { get; set; }

		[Inject]
		public FinishLoadTitleSceneSignal FinishLoadTitleSceneSignal { get; set; }

		[Inject]
		public OnThroughNewDaySignal OnThroughNewDaySignal { get; set; }

		[Inject]
		public ShowAskForRatePopupSignal ShowAskForRatePopupSignal { get; set; }

		[Inject]
		public LoadCharacerSelectionScreenSignal LoadCharacerSelectionScreenSignal { get; set; }

		[Inject]
		public ShowAllAccessoryPackageSignal ShowAllAccessoryPackageSignal { get; set; }

		[Inject]
		public CreateCharacterSignal CreateCharacterSignal { get; set; }

		[Inject]
		public SelectCharacterSignal SelectCharacterSignal { get; set; }

		[Inject]
		public DeleteCharacterSignal DeleteCharacterSignal { get; set; }

		[Inject]
		public CheckRemoteConfigVersionSignal CheckRemoteConfigVersionSignal { get; set; }

		[Inject]
		public FinishCheckConfigSignal FinishCheckConfigSignal { get; set; }

		[Inject]
		public OnFinishCheckConfigSignal OnFinishCheckConfigSignal { get; set; }

		[Inject]
		public ShowConfigDownloadingProgressSignal ShowConfigDownloadingProgressSignal { get; set; }

		[Inject]
		public LoginGameSignal LoginGameSignal { get; set; }

		[Inject]
		public LoginGameErrorSignal LoginGameErrorSignal { get; set; }

		[Inject]
		public LoginGameSuccessSignal LoginGameSuccessSignal { get; set; }

		[Inject]
		public ShowAutoSaveNotifyPopupSignal ShowAutoSaveNotifyPopupSignal { get; set; }

		[Inject]
		public BuyCharacterSignal BuyCharacterSignal { get; set; }

		[Inject]
		public ShowStreamVideoProgressTextSignal ShowStreamVideoProgressTextSignal { get; set; }

		[Inject]
		public HideStreamVideoProgressTextSignal HideStreamVideoProgressTextSignal { get; set; }

		[Inject]
		public HideStreamVideoPopupSignal HideStreamVideoPopupSignal { get; set; }

		[Inject]
		public ShowLinkAccountPopupSignal ShowLinkAccountPopupSignal { get; set; }

		[Inject]
		public ShowAskForSavePopupSignal ShowAskForSavePopupSignal { get; set; }

		[Inject]
		public HideSettingPopupSIgnal HideSettingPopupSIgnal { get; set; }

		[Inject]
		public DownloadDynamicAssetProgressSignal DownloadDynamicAssetProgressSignal { get; set; }

		[Inject]
		public FinishDownloadDynamicAssetSignal FinishDownloadDynamicAssetSignal { get; set; }

		[Inject]
		public FinishPrepareToLoginSignal FinishPrepareToLoginSignal { get; set; }

		[Inject]
		public ShowBackgroundPopupSignal ShowBackgroundPopupSignal { get; set; }

		[Inject]
		public CheckAndInitLanguageSignal CheckAndInitLanguageSignal { get; set; }

		[Inject]
		public OnSaveToCloudSuccessSignal OnSaveToCloudSuccessSignal { get; set; }

		[Inject]
		public ShowMainSceneSubPopupSigal ShowMainSceneSubPopupSigal { get; set; }

		[Inject]
		public ShowDailyQuestPopupSignal ShowDailyQuestPopupSignal { get; set; }

		[Inject]
		public ClaimDailyQuestSignal ClaimDailyQuestSignal { get; set; }

		[Inject]
		public ClaimMasterQuestSignal ClaimMasterQuestSignal { get; set; }

		[Inject]
		public ShowNewDailyQuestNotifyPopupSignal ShowNewDailyQuestNotifyPopupSignal { get; set; }

		[Inject]
		public ShowCosmeticGalleryPopupSignal ShowCosmeticGalleryPopupSignal { get; set; }

		[Inject]
		public ShowAwakenEquipmentPopupSignal ShowAwakenEquipmentPopupSignal { get; set; }

		[Inject]
		public AddAwakenEquipmentMaterialSignal AddAwakenEquipmentMaterialSignal { get; set; }

		[Inject]
		public RemoveAwakenEquipmentMaterialSignal RemoveAwakenEquipmentMaterialSignal { get; set; }

		[Inject]
		public HideEquipmentComparerPopupSignal HideEquipmentComparerPopupSignal { get; set; }

		[Inject]
		public AwakenEquipmentSignal AwakenEquipmentSignal { get; set; }

		[Inject]
		public ShowAwakenEquipmentSuccessPopupSignal ShowAwakenEquipmentSuccessPopupSignal { get; set; }

		[Inject]
		public HideAwakenEquipmentPopupSignal HideAwakenEquipmentPopupSignal { get; set; }

		[Inject]
		public UpdateAwakenEquipmentPopupSignal UpdateAwakenEquipmentPopupSignal { get; set; }

		[Inject]
		public UnequipAllEquipmentSignal UnequipAllEquipmentSignal { get; set; }

		[Inject]
		public ShowMasteryPopupSignal ShowMasteryPopupSignal { get; set; }

		[Inject]
		public TrainMasterySignal TrainMasterySignal { get; set; }

		[Inject]
		public TrainAllMasterySignal TrainAllMasterySignal { get; set; }

		[Inject]
		public SelectMasteryToTrainSignal SelectMasteryToTrainSignal { get; set; }

		[Inject]
		public HideTrainMasteryContainerSignal HideTrainMasteryContainerSignal { get; set; }

		[Inject]
		public AddMaterialToTrainMasterySignal AddMaterialToTrainMasterySignal { get; set; }

		[Inject]
		public RemoveMaterialToTrainMasterySignal RemoveMaterialToTrainMasterySignal { get; set; }

		[Inject]
		public ShowTrainMasterySuccessPopupSignal ShowTrainMasterySuccessPopupSignal { get; set; }

		[Inject]
		public ShowArenaRewardListPopupSignal ShowArenaRewardListPopupSignal { get; set; }

		[Inject]
		public ShowArenaPromotionRankRewardListPopupSignal ShowArenaPromotionRankRewardListPopupSignal { get; set; }

		[Inject]
		public ShowArenaDailyRewardPopupSignal ShowArenaDailyRewardPopupSignal { get; set; }

		[Inject]
		public LoadTestPvpSceneSignal LoadTestPvpSceneSignal { get; set; }

		[Inject]
		public CheckEnterDuelArenaSignal CheckEnterDuelArenaSignal { get; set; }

		[Inject]
		public EnterDuelArenaSignal EnterDuelArenaSignal { get; set; }

		[Inject]
		public ShowStartNewSeasonPopupSignal ShowStartNewSeasonPopupSignal { get; set; }

		[Inject]
		public CheckShowArenaPopupSignal CheckShowArenaPopupSignal { get; set; }

		[Inject]
		public ShowCurrentSeasonPopupSignal ShowCurrentSeasonPopupSignal { get; set; }

		[Inject]
		public ClaimEndSeasonRewardSignal ClaimEndSeasonRewardSignal { get; set; }

		[Inject]
		public AddRewardFromClaimArenaEndSeasonSignal AddRewardFromClaimArenaEndSeasonSignal { get; set; }

		[Inject]
		public AddRewardFromArenaPromotionRewardSignal AddRewardFromArenaPromotionRewardSignal { get; set; }

		[Inject]
		public ShowUserInfoPopupSignal ShowUserInfoPopupSignal { get; set; }

		[Inject]
		public ViewArenaUserInfoSignal ViewArenaUserInfoSignal { get; set; }

		[Inject]
		public GetArenaLeaderBoardDataSignal GetArenaLeaderBoardDataSignal { get; set; }

		[Inject]
		public ReshowArenaUserInfoSignal ReshowArenaUserInfoSignal { get; set; }

		[Inject]
		public ShowUserMasteryInfoPopupSignal ShowUserMasteryInfoPopupSignal { get; set; }

		[Inject]
		public ShowPetListPopupSignal ShowPetListPopupSignal { get; set; }

		[Inject]
		public ShowPetManagerPopupSignal ShowPetManagerPopupSignal { get; set; }

		[Inject]
		public ReShowPetManagerPopupSignal ReShowPetManagerPopupSignal { get; set; }

		[Inject]
		public ShowFirstAnniversaryQuestPopupSignal ShowFirstAnniversaryQuestPopupSignal { get; set; }

		[Inject]
		public ClaimFirstAnniversaryQuestRewardSignal ClaimFirstAnniversaryQuestRewardSignal { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestpopupSignal UpdateFirstAnniversaryQuestpopupSignal { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		[Inject]
		public ShowFirstAnniversaryLoginPopupSignal ShowFirstAnniversaryLoginPopupSignal { get; set; }

		[Inject]
		public ClaimFirstAnniversaryLoginRewardSignal ClaimFirstAnniversaryLoginRewardSignal { get; set; }

		[Inject]
		public OnClaimFirstAnniversaryLoginRewardSuccessSignal OnClaimFirstAnniversaryLoginRewardSuccessSignal { get; set; }

		[Inject]
		public ShowXmasLoginPopupSignal ShowXmasLoginPopupSignal { get; set; }

		[Inject]
		public ClaimXmasLoginRewardSignal ClaimXmasLoginRewardSignal { get; set; }

		[Inject]
		public OnClaimXmasLoginRewardSuccessSignal OnClaimXmasLoginRewardSuccessSignal { get; set; }

		[Inject]
		public ShowXmasOnlinePopupSignal ShowXmasOnlinePopupSignal { get; set; }

		[Inject]
		public CheckClaimXmasOnlineSignal CheckClaimXmasOnlineSignal { get; set; }

		[Inject]
		public ValidateXmasOnlineTimeSignal ValidateXmasOnlineTimeSignal { get; set; }

		[Inject]
		public OnClaimXmasOnlineRewardSuccessSignal OnClaimXmasOnlineRewardSuccessSignal { get; set; }

		[Inject]
		public UpdateXmasWarQuestProgressSignal UpdateXmasWarQuestProgressSignal { get; set; }

		[Inject]
		public ClaimXmasWarMilestoneSignal ClaimXmasWarMilestoneSignal { get; set; }

		[Inject]
		public OnClaimXmasWarMilestoneSuccessSignal OnClaimXmasWarMilestoneSuccessSignal { get; set; }

		[Inject]
		public ShowXmasWarPopupSignal ShowXmasWarPopupSignal { get; set; }

		[Inject]
		public ShowEnhanceAncientPopupSignal ShowEnhanceAncientPopupSignal { get; set; }

		[Inject]
		public UpdateEnhanceAncientPopupSignal UpdateEnhanceAncientPopupSignal { get; set; }

		[Inject]
		public AddEnhanceAncientMaterialSignal AddEnhanceAncientMaterialSignal { get; set; }

		[Inject]
		public RemoveEnhanceAncientMaterialSignal RemoveEnhanceAncientMaterialSignal { get; set; }

		[Inject]
		public EnhanceAncientSignal EnhanceAncientSignal { get; set; }

		[Inject]
		public ShowEnhanceAncientSuccessPopupSignal ShowEnhanceAncientSuccessPopupSignal { get; set; }

		[Inject]
		public ShowSoulLinkPopupSignal ShowSoulLinkPopupSignal { get; set; }

		[Inject]
		public ShowCampaignPopupSignal ShowCampaignPopupSignal { get; set; }

		[Inject]
		public UpdateCampaignQuestSignal UpdateCampaignQuestSignal { get; set; }

		[Inject]
		public ClaimCampaignQuestSignal ClaimCampaignQuestSignal { get; set; }

		[Inject]
		public UpdateCampaignArenaQuestSignal UpdateCampaignArenaQuestSignal { get; set; }

		[Inject]
		public ShowEventPopupSignal ShowEventPopupSignal { get; set; }
	}
}
