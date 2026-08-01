using System;
using Assets.Scripts.Ssar.CharacterSelection.View;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using Scripts.Config.Stats;
using Ssar.Analytics.Metrics.Ancient;
using Ssar.Analytics.Metrics.Coreloop;
using Ssar.Analytics.Metrics.Feature;
using Ssar.Analytics.Metrics.Generals;
using Ssar.Analytics.Metrics.PlayerProgressions;
using Ssar.Analytics.Metrics.ShopAndIap;
using Ssar.Analytics.Metrics.Social;
using Ssar.Analytics.Metrics.Tutorial;
using Ssar.Analytics.Metrics.Values;
using Ssar.DailyChallenge.Model;
using Ssar.RaidBoss;

namespace Ssar.Analytics.Metrics
{
	public class Metric
	{
		private const string EQUIP_ITEM_TUT = "equipItemTut";

		private GeneralScene generalScene;

		private EnterMainScene enterMainScene;

		private EnterWorldMap enterWorldMap;

		private Ssar.Analytics.Metrics.Generals.EnterDungeonMode enterDungeonMode;

		private SetCharacterName setCharacterName;

		private EndPvp endPvp;

		private EndMatch dungeonEndMatch;

		private EndMatch towerEndMatch;

		private EndMatch arenaEndMatch;

		private EndMatch raidEndMatch;

		private DieInDungeonMode dieInDungeonMode;

		private WinDungeonMode winDungeonMode;

		private LoseDungeonMode loseDungeonMode;

		private DieInTowerMode dieInTowerMode;

		private WinTowerMode winTowerMode;

		private LoseTowerMode loseTowerMode;

		private PlayCardShop playCardShop;

		private PlayResourceShop playResourceShop;

		private PlayCostumeGallery playCostumeGallery;

		public void SendStartGameMetric(GeneralData generalData, StartGame.StartGameSources source, CharacterName characterName)
		{
		}

		public void SendGeneralLoadingScene()
		{
		}

		public void StartTrackGeneralScene(SceneLocation previousLocation, float currentTime)
		{
		}

		public void SendGeneralScene(SceneLocation sceneLocation, float currentTime)
		{
		}

		public string GetCurrentSceneLocation()
		{
			return null;
		}

		public void StartTrackEnterMainScene(GeneralData generalData, float currentTime)
		{
		}

		public void EndTrackEnterMainScene(float currentTime)
		{
		}

		public bool IsTrackingOfEnterMainScene()
		{
			return false;
		}

		public void SendEnterMainScene()
		{
		}

		public void StartTrackEnterWorldMap(GeneralData generalData, float currentTime)
		{
		}

		public void EndTrackEnterWorldMap(float currentTime)
		{
		}

		public bool IsTrackingEnterWorldMap()
		{
			return false;
		}

		public void SendEnterWorldMap()
		{
		}

		public void StartTrackEnterDungeonMode(GeneralData generalData, float currentTime)
		{
		}

		public void EndTrackEnterDungeonMode(float currentTime)
		{
		}

		public bool IsTrackingEnterDungeonMode()
		{
			return false;
		}

		public void SendEnterDungeonMode()
		{
		}

		public void SendGeneralInitData(Ssar.Analytics.Metrics.Values.Version version)
		{
		}

		public void StartTrackSetCharacterName(float currentTime)
		{
		}

		public void EndTrackSetCharacterName(float currentTime)
		{
		}

		public bool IsTrackingSetCharacterName()
		{
			return false;
		}

		public void SendGeneralSetCharacterName(GeneralData generalData, string name)
		{
		}

		public void SendFpsTracking(PlayerProgressionData playerData, int minFps, int maxFps, int below10Fps, int below20Fps)
		{
		}

		public void SendPlayerProgressionStartMatch(PlayerProgressionData playerProgressionData, BattleMode battleMode, string arena, int season)
		{
		}

		public void StartTrackPlayerProgressionEndMatch(PlayerProgressionData playerProgressionData, BattleMode battleMode, string arena, int season, float currentTime)
		{
		}

		public void SendPlayerProgressionEndMatch(BattleMode battleMode, bool isLose, float currentTime)
		{
		}

		public void SendPlayerProgressionEndMatch(EndMatch endMatch, bool isLose, float currentTime)
		{
		}

		public void SendPlayerProgressionLevelUp(PlayerProgressionData playerProgressionData, int exp)
		{
		}

		public void SendPlayerProgressionLevelUpDetail(BaseData baseData, string weaponRarity, string helmetRarity, string chestRarity, string pantRarity, string amuletRarity, string ringRarity)
		{
		}

		public void SendPlayerProgressionUnlockDungeonNode(PlayerProgressionData playerProgressionData)
		{
		}

		public void SendPlayerProgressionEnterDungeonMode(PlayerProgressionData playerProgressionData, bool expBoosterUsed, bool soulBoosterUsed, bool hpPotionUsed, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SendPlayerProgressionEnterTowerMode(PlayerProgressionData playerProgressionData, bool expBoosterUsed, bool soulBoosterUsed, bool hpPotionUsed, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, string towerNode, string highestTowerNode)
		{
		}

		public void StartTrackPlayerProgressionWinInTowerMode(float currentTime, PlayerProgressionData playerProgressionData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, string towerNode, string towerHighestNode)
		{
		}

		private bool IsTrackPlayerProgressionWinInTower()
		{
			return false;
		}

		public void SendWinPlayerProgressionWinInTowerMode(float currentTime, bool isFirstWin, int star)
		{
		}

		public void StartTrackPlayerProgressionDieInTowerMode(PlayerProgressionData playerProgressionData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, float currentTime, string nodeTower, string highestNodeTower)
		{
		}

		public bool IsTrackingPlayerProgressionDieInTowerMode()
		{
			return false;
		}

		public void SendPlayerProgressionDieInTowerMode(float currentTime, string reason)
		{
		}

		public void UseHpPotionOfPlayerProgressionInTowerMode()
		{
		}

		public void StartTrackPlayerProgressionLoseTowerMode(PlayerProgressionData playerProgressionData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, string losingReson, float currentTime, string towerNode, string highestTowerNode)
		{
		}

		public bool IsTrackingPlayerProgressionLoseInTowerMode()
		{
			return false;
		}

		public void SendPlayerProgressionLoseTowerMode(float currentTime, string reason, int tryCount)
		{
		}

		public void StartTrackPlayerProgressionDieInDungeonMode(PlayerProgressionData playerProgressionData, float currentTime)
		{
		}

		public bool IsTrackingPlayerProgressionDieInDungeonMode()
		{
			return false;
		}

		public void EndTrackPlayerProgressionDieInDungeonMode(float currentTime)
		{
		}

		public void SendPlayerProgressionDieInDungeonMode(string reason)
		{
		}

		public void UseHpPotionOfPlayerProgressionInDungeonMode()
		{
		}

		public void StartTrackPlayerProgressionLoseDungeonMode(PlayerProgressionData playerProgressionData, float currentTime)
		{
		}

		public bool IsTrackingPlayerProgressionLoseInDungeonMode()
		{
			return false;
		}

		public void SendPlayerProgressionLoseDungeonMode(float currentTime, string reason, int tryCount)
		{
		}

		public void SendPlayerProgressionRessurectInDungeonMode(PlayerProgressionData playerProgressionData)
		{
		}

		public void SendPlayerProgressionUseHpPotionInDungeonMode(PlayerProgressionData playerProgressionData, int currentHp, int maxHp)
		{
		}

		public void StartTrackPlayerProgressionWinDungeonMode(PlayerProgressionData playerProgressionData, float startTime)
		{
		}

		public bool IsTrackingPlayerProgressionWinDungeonMode()
		{
			return false;
		}

		public void SetAncientOfPlayerProgressionWinDungeonMode(AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SetEntityAbilitiesOfPlayerProgressionWinDungeonMode(EntityAbilities entity)
		{
		}

		public void SetGainedExpOfPlayerProgressionWinDungeonMode(int exp)
		{
		}

		public void SetGainedSoulOfPlayerProgressionWinDungeonMode(int soul)
		{
		}

		public void GainedItemOfPlayerProgressionWinDungeonMode(string rarity)
		{
		}

		public void SetFirstWinOfPlayerProgressionWinDungeonMode(bool firstTime)
		{
		}

		public void SetLoseBeforeClearOfPlayerProgressionWinDungeonMode(int loseBeforeClear)
		{
		}

		public void EndTrackPlayerProgressionWinDungeonMode(float currentTime)
		{
		}

		public void SendPlayerProgressionWinDungeonMode()
		{
		}

		public void SendPlayerProgressionCreateHero(CharacterName characterName, int count, CreateCharacterWidget.CharacterCreationSource characterCreationSource)
		{
		}

		public void SendPlayerProgressionFirstTimeClearDungeon(PlayerProgressionData playerProgressionData, int failCount)
		{
		}

		public void SendCoreloopInvestSkillPoint(CoreloopData coreloopData, int skillPoint, int purchasedSkillPoint, string skillId, string runeId)
		{
		}

		public void SendCoreloopUninvestSkillPoint(CoreloopData coreloopData, int skillPoint, int purchasedSkillPoint, string skillId, string runeId)
		{
		}

		public void SendCoreloopPurchaseSkillPoint(CoreloopData coreloopData, int skillPoint, int purchasedSkillPoint, int quantity)
		{
		}

		public void SendCoreloopUpgradeItem(CoreloopData coreloopData, string itemType, string rarity, int currentEnhanceLevel, int visualId, int enhancePrice)
		{
		}

		public void SendCoreloopSellItem(CoreloopData coreloopData, string itemType, string rarity, int price)
		{
		}

		public void SendCoreloopExpandInventoryCapacity(CoreloopData coreloopData, int quantity, float cost, string currency)
		{
		}

		public void SendCoreloopReceivedAchievement(CoreloopData coreloopData, int achievementId, string achievementName, int rewardValue, string typeReceived)
		{
		}

		public void SendCoreloopReceivedDailyLogin(CoreloopData coreloopData, int dailyCount, int eventId, string nameReward)
		{
		}

		public void SendCoreLoopSoulIn(CoreloopData coreloopData, string source, int quantity)
		{
		}

		public void SendCoreLoopSoulOut(CoreloopData coreloopData, string source, int quantity)
		{
		}

		public void SendShopAndIapBuyResource(ShopAndIapData shopAndIapData, string goodName, string sku)
		{
		}

		public void SendShopAndIapBuyPackageBundle(ShopAndIapData shopAndIapData, string goodName, string sku, bool shouldAppendCharacterPostfix)
		{
		}

		public void SendShopAndIapBuyCard(ShopAndIapData shopAndIapData, string goodName, string sku)
		{
		}

		public void SendShopAndIapBuyFromVendor(ShopAndIapData shopAndIapData, string goodName, string sku)
		{
		}

		public void SendShopAndIapResetVendor(ShopAndIapData shopAndIapData)
		{
		}

		public void SendShopAndIapShowPackageBundle(ShopAndIapData shopAndIapData, string goodName, string sku)
		{
		}

		public void SendShopAndIapWatchVod(ShopAndIapData shopAndIapData, string source)
		{
		}

		public void SendShopAndIapRewardVod(ShopAndIapData shopAndIapData, string source)
		{
		}

		public void SendShopAndIapBuyHero(ShopAndIapData said, string goodName, string sku)
		{
		}

		public void SendShopAndIapIntersAdsShow(ShopAndIapData said)
		{
		}

		public void SendShopAndIapTestHero(ShopAndIapData said, string heroName)
		{
		}

		public void SendShopPurchased(ShopAndIapData said, string itemCategory, string itemName, string itemId, string currencyType, double price, int purchasedItemCount, int purchasedCount, int viewCount)
		{
		}

		public void SendCoreLoopCrystalIn(CoreloopData coreloopData, string source, int quantity)
		{
		}

		public void SendCoreLoopCrystalOut(CoreloopData coreloopData, string source, int quantity)
		{
		}

		public void SendCoreLoopInvestMastery(CoreloopData coreloopData, string masteryName, int masterySubLevel, int masteryTotalLevel)
		{
		}

		public void SendCoreLoopArena(MetricName metricName, CoreloopData coreloopData, int seasonalCode)
		{
		}

		public void SendCoreLoopClaimRewardPvp(CoreloopData coreloopData, int seasonalCode)
		{
		}

		public void SendCoreLoopAwakenPet(CoreloopData coreloopData, string petName, string petRarity)
		{
		}

		public void SendCoreLoopStartPvp(CoreloopData coreloopData, int seasonalCode, string arena, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, int rivalPower)
		{
		}

		public void StartTrackCoreLoopEndPvp(float currentTime, int rivalPower)
		{
		}

		public void SendCoreLoopEndPvp(float timeCurrent, CoreloopData coreloopData, int seasonalCode, string arena, bool isLose, EntityAbilities heroEntity)
		{
		}

		public void SendCoreLoopMatchup(MetricName metricName, string winnerName, int seasonalCode)
		{
		}

		public void SendCoreLoopArenaRankup(CoreloopData coreloopData)
		{
		}

		public void SendCoreLoopChooseRune(string runeName, int seasonalCode)
		{
		}

		public void SendCoreLoopUpgradePet(CoreloopData coreloopData, string petName, string petRarity, int currentEnhanceLevel)
		{
		}

		public void SendCoreLoopSellPet(CoreloopData coreloopData, string petName, string petRarity)
		{
		}

		public void SendCoreLoopReforgeBegin(CoreloopData coreloopData, string oreRuneName, string itemType, string itemRarity)
		{
		}

		public void SendCoreLoopReforgeEnd(CoreloopData coreloopData, string oreRuneName, string itemType, string itemRarity, string action)
		{
		}

		public void SendCoreLoopCraft(CoreloopData coreloopData, string itemType, string itemRarity, int soulCost)
		{
		}

		public void SendCoreLoopSalvage(CoreloopData coreloopData, int quantity)
		{
		}

		public void SendCoreLoopJoinRaid(CoreloopData coreloopData, int seasonalCode)
		{
		}

		public void SendCoreLoopClaimRaidSeasonalReward(CoreloopData coreloopData, int seasonalCode)
		{
		}

		public void SendCoreLoopEnterRaid(CoreloopData coreloopData, int characterPower, int bossPower, RaidDifficulty difficulty, Mode mode, int seasonalCode, string rank, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SendCoreLoopLoseRaid(CoreloopData coreloopData, int characterPower, int bossPower, RaidDifficulty difficulty, Mode mode, int seasonalCode, LoseRaid.Reason reason, int battleTime)
		{
		}

		public void SendCoreLoopWinRaid(CoreloopData coreloopData, int characterPower, int bossPower, RaidDifficulty difficulty, Mode mode, int seasonalCode, int battleDurationInMinutes)
		{
		}

		public void SendShopCheckout(ShopAndIapData said, string itemCategory, string itemName, string itemId, string currentType, double money, int purchasedCount)
		{
		}

		public void SendShopViewStore(ShopAndIapData shopAndIapData)
		{
		}

		public void SendShopViewItem(string itemCategory, string itemName, string itemId, double money, string currentType, int itemViewCount)
		{
		}

		public void StartTrackShopAndIapPlayCardShop(ShopAndIapData shopAndIapData, float currentTime)
		{
		}

		public void EndTrackShopAndIapPlayCardShop(float currentTime)
		{
		}

		public void SendShopAndIapPlayCardShop()
		{
		}

		public void StartTrackShopAndIapPlayResourceShop(ShopAndIapData shopAndIapData, float currentTime)
		{
		}

		public void EndTrackShopAndIapPlayResourceShop(float currentTime)
		{
		}

		public void SendShopAndIapPlayResourceShop()
		{
		}

		public void SendShopAndIapClickFirstTimePurchase(ShopAndIapData shopAndIapData)
		{
		}

		public void SendShopAndIapClickHotDeal(ShopAndIapData shopAndIapData)
		{
		}

		public void SendShopClickIconInMainScene(ShopAndIapData shopAndIapData, string itemCategory, int clickToFeature)
		{
		}

		public void StartTrackShopAndIapPlayCostumeGallery(ShopAndIapData shopAndIapData, float currentTime)
		{
		}

		public void EndTrackShopAndIapPlayCostumeGallery(float currentTime)
		{
		}

		public void SendShopAndIapPlayCostumeGallery()
		{
		}

		public void SendTutorialCombatStartCombatTut(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteStepFirstDialog(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteStepMove(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteStepAttack(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteJumpAttack(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteStepDash(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteCastSkill(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteBossAppear(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteShowUltimate(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteCastUltimate(CombatTutorialData ctd)
		{
		}

		public void SendTutorialCompleteBattle(CombatTutorialData ctd)
		{
		}

		public void SendTutorialHubLevelMainSceneStart(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutStart(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutSelectWeapon(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutEquip(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutReward(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutMainScene(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutWorldMap(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutNode(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEquipItemTutStartBattle(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEnhanceItemStart(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEnhanceItemUpgrade(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelEnhanceItemReward(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelUpgradeSkillStart(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelUpgradeSkillUpgrade(CharacterName characterName)
		{
		}

		public void SendTutorialHubLevelUpgradeSkillReward(CharacterName characterName)
		{
		}

		public void SendTutorialCinematicIntroStart(CharacterName characterName)
		{
		}

		public void SendTutorialCinematicIntroEnd(CharacterName characterName)
		{
		}

		public void SendSocialLogin(SocialData socialData)
		{
		}

		public void SendSocialLike(SocialData socialData)
		{
		}

		public void SendSocialInvite(SocialData socialData)
		{
		}

		public void SendSocialShare(SocialData socialData, Share.SharingSource sharingSource)
		{
		}

		public void SendSocialJoinGroup(SocialData socialData)
		{
		}

		public void SendSocialAskForRateShow(SocialData socialData, int dungeonId)
		{
		}

		public void SendSocialAskForRateRate5Star(SocialData socialData, int dungeonId)
		{
		}

		public void SendSocialAskForRateRateComplete(SocialData socialData, VoteResult result)
		{
		}

		public void SendFeatureDailyMissionShow(FeatureData featureData)
		{
		}

		public void SendFeatureDailyMissionMasterQuestCompleted(FeatureData featureData)
		{
		}

		public void SendFeatureDailyMissionMinorQuestCompleted(FeatureData featureData)
		{
		}

		public void SendFeatureAnni(MetricName metricName, int level, int continuousDayCount)
		{
		}

		public void SendFeatureXmas(MetricName metricName, int level, int mile)
		{
		}

		public void SendFeatureXmasLogin(MetricName metricName, int level, int mile, int dayLeft)
		{
		}

		public void SendAncientCraft(BaseData baseData, AncientEquipmentMetric ancientEquipmentMetric)
		{
		}

		public void SendAncientEnhance(BaseData baseData, AncientEquipmentMetric ancientEquipmentMetric, int targetLevel)
		{
		}

		public void SendAncientEnterPvE(BaseData baseData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SendAncientEnterPvP(BaseData baseData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SendAncientEnterRaid(BaseData baseData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SendCampaignClaim(BaseData baseData, int questId, int mile)
		{
		}

		public void SendCampaignClaimMaster(BaseData baseData, int questId, string visualName)
		{
		}

		public void SendEventWarClaim(BaseData baseData, int rewardId, int token)
		{
		}

		public void SendEventWarTokenIn(BaseData baseData, int token, int quantity, RewardReason source)
		{
		}

		public void SendEventWarStartChallenge(BaseData baseData, ScenarioDifficulty difficulty, int battleCount)
		{
		}

		public void SendEventWarEndChallenge(BaseData baseData, ScenarioDifficulty difficulty, bool isWin, int battleCount, DailyChallengeRecord record)
		{
		}

		public void SendEventWarStartRound(BaseData baseData, ScenarioDifficulty difficulty, int round)
		{
		}

		public void SendEventWarPassRound(BaseData baseData, ScenarioDifficulty difficulty, int round)
		{
		}

		public void SendMarketingPvPBattle(BaseData baseData, int battleCount)
		{
		}

		public void SendMarketingDailyLoginClaimed(BaseData baseData, int dayCount)
		{
		}

		public void SendMarketingLevelUp(BaseData baseData)
		{
		}

		public void SendMarketingPassMap(BaseData baseData, int dungeonID)
		{
		}

		public void SendQuinnRequestAwareness()
		{
		}

		public void SendQuinnRequestComplete(int questId, int coinValue)
		{
		}

		public void SendQuinnRequestExchange(int giftId, int coinValue)
		{
		}

		public void SendQuinnRequestPreviousCoins()
		{
		}

		public void SendMoreThanCrystalsExchange(int value)
		{
		}

		public void SendMoreThanSoulsExchange(int value)
		{
		}

		public void SendMoreThanCrystalsAwareness()
		{
		}

		public void SendMoreThanSoulsAwareness()
		{
		}

		private void Try(Action action)
		{
		}
	}
}
