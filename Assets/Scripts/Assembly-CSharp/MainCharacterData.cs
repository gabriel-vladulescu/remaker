using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Mastery;
using Assets.Scripts.Ssar.AnniversaryEvent;
using Assets.Scripts.Ssar.DataManager;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Shop.Model;
using Assets.Scripts.Ssar.Social.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.Entry.Model;
using SSAR.Equipment.Model;
using SSAR.WorldMap.Model;
using Scripts.Ssar.Arena;
using Scripts.Ssar.Pet;
using Ssar.Craft.Model;
using Ssar.DailyChallenge.Model;
using Ssar.Database.Compressor;
using Ssar.Event.DemonInvasion.Model;
using Ssar.Event.EventLogin.Model;
using Ssar.Event.EventPopup;
using Ssar.Event.EventWar.Model;
using Ssar.Event.SevenDaysCampaign.Model;
using Ssar.Event.Xmas;
using Ssar.RaidBoss.Model;
using Ssar.Shop.Model;

[Serializable]
public class MainCharacterData
{
	public delegate void OnSoulChanged(int soulBeforeChanged, int soulAfterChanged, string source);

	public delegate void OnCrystalChanged(int crystalBeforeChanged, int crystalAfterChanged, string source);

	public bool isUseNewExpFormula;

	public double realMoneySpent;

	public string displayName;

	public int timeCreateCharacter;

	public int totalTimePlayed2;

	public BaseKeyData stamina;

	public BaseKeyData videoPoint;

	public CharacterEquippedEquipmentData _characterEquippedEquipmentData;

	public ItemLockData equipmentLockData;

	public CharacterSkillData characterSkillData;

	public ShopVendorData shopVendorData;

	public Dictionary<string, DailyLoginData> dailyLoginDatas;

	public AchievementData achievementData;

	public HighestValueData highestValueData;

	public LevelUpPackageBoughtData levelUpPackageBoughtData;

	public BloodyTowerProgressData bloodyTowerProgressData;

	public BundlePackageBoughtData BundlePackageBoughtData;

	public List<SubscribePackageBoughtData> subscribePackageBoughtDatas;

	public HellModeData hellModeData;

	public TutorialData tutorialData;

	public DailyQuestData dailyQuestData;

	public WorldMapData worldMapData;

	public CountryInfo CountryInfo;

	public bool isBanned;

	[JsonInclude]
	private ObscuredInt skillPointPurchased;

	[JsonInclude]
	private ObscuredInt soulObscuredInt;

	[JsonInclude]
	private ObscuredInt expObscuredInt;

	[JsonInclude]
	private ObscuredInt crystalObscuredInt;

	[JsonInclude]
	private FirstTopUpBoughtData firstTopUpBoughtData;

	[JsonInclude]
	private List<NewLevelUpPackageBoughtData> levelUpPackageBoughtDatas;

	[JsonInclude]
	private List<NewSubscribePackageBoughtData> newSubscribePackageBoughtDatas;

	[JsonInclude]
	private ObscuredInt freeSubscribePackageBoughtCount;

	[JsonInclude]
	private FeatureUnlockedData featureUnlocked;

	[JsonInclude]
	private DungeonWatchVodData dungeonWatchVodData;

	[JsonInclude]
	private MasteryData masteryData;

	[JsonInclude]
	private PiggyBankData piggyBankData;

	[JsonInclude]
	private DuelArenaData duelArenaData;

	[JsonInclude]
	private string deviceId;

	[JsonInclude]
	private PetEquippedData petEquippedData;

	[JsonInclude]
	private CrystalLogData crystalLogData;

	[JsonInclude]
	private FirstAnniversaryQuestData firstAnniversaryQuestData;

	[JsonInclude]
	private FirstAnniversaryLoginData firstAnniversaryLoginData;

	[JsonInclude]
	private RaidData raidData;

	[JsonInclude]
	private CraftingData craftingData;

	[JsonInclude]
	private RandomSeedData randomSeedData;

	[JsonInclude]
	private XmasEventData xmasEventData;

	[JsonInclude]
	private SoulLogData soulLogData;

	[JsonInclude]
	private PiggyBankData crystalPiggyBankData;

	[JsonInclude]
	private DoubleExpBoughtData doubleExpBoughtData;

	[JsonInclude]
	private FlashSaleEventData flashSaleEventData;

	[JsonInclude]
	private SkillAndEquipmentPresetData pvePresetData;

	[JsonInclude]
	private SkillAndEquipmentPresetData pvpPresetData;

	[JsonInclude]
	private CampaignData sevenDayCampaignData;

	[JsonInclude]
	private BaseKeyData videoTicket;

	[JsonInclude]
	private CharacterCompressedData compressedData;

	[JsonInclude]
	private EventWarData eventWarData;

	[JsonInclude]
	private EventLoginData eventLoginData;

	[JsonInclude]
	private Dictionary<string, EventWarData> eventWarDatas;

	[JsonInclude]
	private string eventWarLastestId;

	[JsonInclude]
	private Dictionary<string, int> purchasedCountData;

	[JsonInclude]
	private Dictionary<string, int> itemViewCountData;

	[JsonInclude]
	private Dictionary<string, int> tryBattleCount;

	[JsonInclude]
	private Dictionary<string, int> clickToObjectInScene;

	[JsonInclude]
	private bool actionAfterBuyCrystal;

	[JsonInclude]
	private bool fightingAfterBuyWithMoney;

	[JsonInclude]
	private int itemPurchasedCount;

	[JsonInclude]
	private DemonInvasionData demonInvasionData;

	[JsonInclude]
	private FreeEquipmentData freeEquipmentData;

	[JsonInclude]
	private AllCharactersBoughtData allCharactersBoughtData;

	[JsonInclude]
	private FlashSaleOreRuneBoughtData flashSaleOreRuneBoughtData;

	[JsonInclude]
	private ShopBlackFridayData shopBlackFridayData;

	[JsonInclude]
	private QuinnRequestEventData quinnRequestEventData;

	[JsonInclude]
	private MoreThanCrystalEventData moreThanCrystalEventData;

	[JsonInclude]
	private MoreThanSoulEventData moreThanSoulEventData;

	public int level;

	public long power;

	public string firebaseUID;

	public int groupId { get; set; }

	public int subId { get; set; }

	public int id { get; set; }

	public int exp
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int soul
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int crystal
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public InventoryData inventoryData { get; set; }

	public FacebookRewardData facebookRewardData { get; set; }

	public bool ActionAfterBuyCrystal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FightingAfterBuyWithMoney
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public int EventWarToken => 0;

	[JsonIgnore]
	public EventLoginData EventLoginData => null;

	public event OnSoulChanged OnSoulChangedEvent;

	public event OnCrystalChanged OnCrystalChangedEvent;

	public MainCharacterData()
	{
	}

	public MainCharacterData(int id)
	{
	}

	private void InitKey()
	{
	}

	public void SetId(int id)
	{
	}

	public void SetDisplayName(string displayName)
	{
	}

	public string GetDisplayName()
	{
		return null;
	}

	public int GetCrystal()
	{
		return 0;
	}

	private void SetCrystal(int crystal, string source)
	{
	}

	public void AddCrystal(int crystal, string source, RewardReason rewardReason)
	{
	}

	public void ConsumeCrystal(int crystal, string source, Reason reason)
	{
	}

	public int GetExp()
	{
		return 0;
	}

	public void SetExp(int exp)
	{
	}

	public int GetSoul()
	{
		return 0;
	}

	private void SetSoul(int soul, string source)
	{
	}

	public void AddSoul(int soul, string source, RewardReason rewardReason)
	{
	}

	public void AddStamina(int stamina)
	{
	}

	public void ConsumeSoul(int soul, string source, Reason rewardReason)
	{
	}

	public void SetStaminaKeyConfig(int maxKey, int intervalInSeconds)
	{
	}

	public void SetVideoPointConfig(int max, int intervalInSeconds)
	{
	}

	public void AddVideoPoint(int videoPoint)
	{
	}

	public void AddVideoTicket(int videoTicket)
	{
	}

	public void SetInventoryData(InventoryData inventoryData)
	{
	}

	public void SetEquipEquipmentData(CharacterEquippedEquipmentData equippedEquipmentData)
	{
	}

	public void SetWorldMapData(WorldMapData worldMapData)
	{
	}

	public void SetEquipmentLockData(ItemLockData equipmentLockData)
	{
	}

	public void SetSkillData(CharacterSkillData characterSkillData)
	{
	}

	public void SetTutorialData(TutorialData tutorialData)
	{
	}

	public WorldMapData GetWorldMapData()
	{
		return null;
	}

	public BaseKeyData GetStaminaData()
	{
		return null;
	}

	public BaseKeyData GetVideoPointData()
	{
		return null;
	}

	public BaseKeyData GetVideoTicketData()
	{
		return null;
	}

	public InventoryData GetInventoryData()
	{
		return null;
	}

	public ItemLockData GetItemLockData()
	{
		return null;
	}

	public CharacterEquippedEquipmentData GetCharacterEquippedEquipmentData()
	{
		return null;
	}

	public LevelUpPackageBoughtData GetOldLevelUpPackageBoughtData()
	{
		return null;
	}

	public CharacterSkillData GetCharacterSkillData()
	{
		return null;
	}

	public DailyLoginData GetDailyLoginData()
	{
		return null;
	}

	public int IncreaseClickObjectInMainScene(string typeItem)
	{
		return 0;
	}

	public int IncreaseTry(BattleMode battleMode)
	{
		return 0;
	}

	public int GetViewItemCount(string sku)
	{
		return 0;
	}

	public int IncreaseViewItemCount(string sku)
	{
		return 0;
	}

	public int IncreaseItemPurchasedCount(string sku)
	{
		return 0;
	}

	public int IncreasePurchasedCount()
	{
		return 0;
	}

	public void AddNewDailyLoginData(DailyLoginData dailyLoginData)
	{
	}

	public ShopVendorData GetShopVendorData()
	{
		return null;
	}

	public void SetShopVendorData(ShopVendorData shopVendorData)
	{
	}

	public AchievementData GetAchievementData()
	{
		return null;
	}

	public void SetAchievementData(AchievementData achievementData)
	{
	}

	public DailyQuestData GetDailyQuestData()
	{
		return null;
	}

	public void SetDailyQuestData(DailyQuestData dailyQuestData)
	{
	}

	public CampaignData GetSevenDayCampaignData()
	{
		return null;
	}

	public void SetSevenDayCampaignData(CampaignData campaignData)
	{
	}

	public HighestValueData GetHighestValueData()
	{
		return null;
	}

	public FacebookRewardData GetFacebookRewardData()
	{
		return null;
	}

	public BundlePackageBoughtData GetBundlePackageBoughtData()
	{
		return null;
	}

	public void AddTimePlayed(int second)
	{
	}

	public int GetTotalTimePlayed()
	{
		return 0;
	}

	public SubscribePackageBoughtData GetOldSubscriptionPackageBoughtData()
	{
		return null;
	}

	public NewSubscribePackageBoughtData GetNewSubscriptionPackageBoughtData()
	{
		return null;
	}

	public int GetFreeSubscribePackageBoughtCount()
	{
		return 0;
	}

	public void BoughtFreeSubscribePackage()
	{
	}

	public bool IsUseNewExpFormula()
	{
		return false;
	}

	public void UpdateNewExpFormala(int newExp)
	{
	}

	public void AddRealMoneySpent(double realMoneySpent)
	{
	}

	public double GetRealMoneySpent()
	{
		return 0.0;
	}

	public void ListenToSoulChangedEvent(OnSoulChanged listener)
	{
	}

	public void UnlistenToSoulChangedEvent(OnSoulChanged listener)
	{
	}

	public void ListenToCrystalChangedEvent(OnCrystalChanged listener)
	{
	}

	public void UnlistenToCrystalChangedEvent(OnCrystalChanged listener)
	{
	}

	public TutorialData GetTutorialData()
	{
		return null;
	}

	public int GetTimeCreateCharacter()
	{
		return 0;
	}

	public void SetTimeCreateCharacter(int timeInSecond)
	{
	}

	public BloodyTowerProgressData GetBloodyTowerProgressData()
	{
		return null;
	}

	public void SetTowerProgressData(BloodyTowerProgressData towerProgressData)
	{
	}

	public void BoughtNewLevelUpPackage(int productId)
	{
	}

	public bool HasBoughtLevelUpPackageWithProductId(int productId)
	{
		return false;
	}

	public bool GetLastestLevelUpPackageBought(ref NewLevelUpPackageBoughtData data)
	{
		return false;
	}

	public FirstTopUpBoughtData GetFirstTopUpBoughtData()
	{
		return null;
	}

	public void AddSkillPoinPurchase(int skillPoint)
	{
	}

	public int GetSkillPointPurchased()
	{
		return 0;
	}

	public void SetSkillPointPurchase(int skillPoint)
	{
	}

	public FeatureUnlockedData GetFeatureUnlockedData()
	{
		return null;
	}

	public DungeonWatchVodData GetDungeonWatchVodData()
	{
		return null;
	}

	public MasteryData GetMasteryData()
	{
		return null;
	}

	public PiggyBankData GetPiggyBankData(PiggyBankType piggyBankType)
	{
		return null;
	}

	public DuelArenaData GetDuelArenaData()
	{
		return null;
	}

	public void SetDeviceId(string deviceId)
	{
	}

	public string GetDeviceId()
	{
		return null;
	}

	public PetEquippedData GetPetEquippedData()
	{
		return null;
	}

	public void SetPetEquippedData(PetEquippedData petEquippedData)
	{
	}

	public FirstAnniversaryQuestData GetFirstAnniversaryQuestData()
	{
		return null;
	}

	public void SetFirstAnniversaryLoginData(FirstAnniversaryLoginData data)
	{
	}

	public FirstAnniversaryLoginData GetFirstAnniversaryLoginData()
	{
		return null;
	}

	public RaidData GetRaidData()
	{
		return null;
	}

	public XmasLoginData GetXmasLoginData()
	{
		return null;
	}

	public void SetXmasLoginData(XmasLoginData data)
	{
	}

	public XmasOnlineData GetXmasOnlineData()
	{
		return null;
	}

	public void SetXmasOnlineData(XmasOnlineData data)
	{
	}

	public void SetXmasWarData(XmasWarData data)
	{
	}

	public XmasWarData GetXmasWarData()
	{
		return null;
	}

	public XmasEventData GetXmasEventData()
	{
		return null;
	}

	public void SetXmasEventData(XmasEventData xmasEventData)
	{
	}

	public CraftingData GetCraftingData()
	{
		return null;
	}

	public RandomSeedData GetRandomSeedData()
	{
		return null;
	}

	public void SetRandomSeedData(RandomSeedData randomSeedData)
	{
	}

	public void UpdateData(MasteryData masteryData)
	{
	}

	public void UpdateData(PetEquippedData petEquippedData)
	{
	}

	public void UpdateData(CrystalLogData crystalLogData)
	{
	}

	public void UpdateData(XmasEventData xmasEventData)
	{
	}

	public void UpdateData(SoulLogData soulLogData)
	{
	}

	public void UpdateData(DoubleExpBoughtData doubleExpBoughtData)
	{
	}

	public void UpdateData(CampaignData campaignData)
	{
	}

	public void UpdateData(CraftingData craftingData)
	{
	}

	public SoulLogData GetSoulLogData()
	{
		return null;
	}

	public CrystalLogData GetCrystalLogData()
	{
		return null;
	}

	public DoubleExpBoughtData GetDoubleExpBoughtData()
	{
		return null;
	}

	public FlashSaleEventData GetFlashSaleEventData()
	{
		return null;
	}

	public SkillAndEquipmentPresetData GetPreset(Preset preset)
	{
		return null;
	}

	public SkillAndEquipmentPresetData GetPvpPreset()
	{
		return null;
	}

	public void SetPreset(Preset preset, SkillAndEquipmentPresetData data)
	{
	}

	public HellModeData GetHellModeData()
	{
		return null;
	}

	public CharacterCompressedData GetCompressedData()
	{
		return null;
	}

	public bool IsJoinedDemonInvasion(string id)
	{
		return false;
	}

	public DemonInvasionData AddNewDemonInvasionData(DemonInvasionData data)
	{
		return null;
	}

	public DemonInvasionData GetDemonInvasionData()
	{
		return null;
	}

	public void RemoveDemonInvasionData()
	{
	}

	public EventWarData GetOldEventWarData()
	{
		return null;
	}

	public void RemoveOldEventWarData()
	{
	}

	public EventWarData GetEventWarData()
	{
		return null;
	}

	public void AddNewEventWarData(EventWarData data)
	{
	}

	public bool IsJoinedEventWar(string id)
	{
		return false;
	}

	public List<EventWarData> GetAllEventWarDatas()
	{
		return null;
	}

	public DailyChalllengeData GetDailyChalllengeData()
	{
		return null;
	}

	public void AddEventWarToken(int token, RewardReason source)
	{
	}

	public FreeEquipmentData GetFreeEquipmentData()
	{
		return null;
	}

	public AllCharactersBoughtData GetAllCharactersBoughtData()
	{
		return null;
	}

	public FlashSaleOreRuneBoughtData GetFlashSaleOreRuneBoughtData()
	{
		return null;
	}

	public ShopBlackFridayData GetShopBlackFridayData()
	{
		return null;
	}

	public QuinnRequestEventData GetQuinnRequestEventData()
	{
		return null;
	}

	public MoreThanCrystalEventData GetMoreThanCrystalEventData()
	{
		return null;
	}

	public MoreThanSoulEventData GetMoreThanSoulEventData()
	{
		return null;
	}
}
