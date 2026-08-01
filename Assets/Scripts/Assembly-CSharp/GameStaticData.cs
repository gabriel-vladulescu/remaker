using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Entry;
using SSAR.BattleSystem.Input;
using SSAR.Entry.Model;
using SSAR.Equipment.View;
using Scripts.Config;
using Scripts.Ssar.Arena;
using Scripts.Ssar.Pet;
using Ssar.Database;
using Ssar.Iap;
using Ssar.Rune.Model;
using UnityEngine;
using buildTools;

public class GameStaticData
{
	private int currentNodeEnter;

	private string currentScene;

	private AbstractInventoryView abstractInventoryView;

	private Dictionary<Type, GameObject> cachePopup;

	private Dictionary<EquipmentCategory, bool> dictCategoryEquipmentObtained;

	private Dictionary<Ssar.Rune.Model.RuneType, bool> dictCategoryRuneObtained;

	private bool craftingMaterialObtained;

	private bool enableCheckLevelUpPackage;

	private bool isInLoadingScene;

	private bool hasShowSubsciptionPackage;

	private bool isFirstTimeLogin;

	private bool isPaused;

	private bool isInTutorial;

	public bool isAcceptPlayHellMode;

	public bool applyLinkData;

	public int newFloorUnlock;

	public int timeStartPlayCurrentCharacter;

	public bool hasEnterMainScene;

	public bool hasCheckConfig;

	public bool enableAutoSave;

	public InitFirebaseDatabaseCommand.FirebaseAvailability FirebaseAvailability;

	private FacebookSocial facebookSocial;

	private List<Camera> cacheCameras;

	private IBattleModeLogic _battleModeLogic;

	private int lastAdventureDungeonId;

	private int lastBloodyDungeonId;

	private int lastRaidDungeonId;

	private int lastDailyChalllengeDungeonId;

	private bool enableNotiAskForRate;

	private bool enableNotiAskForSave;

	private AbsCharacterGenerateEquipmentLogic absCharacterGenerateEquipmentLogic;

	private BuyCharacterParameter buyCharacterParameter;

	private AbsLoadAssetControlLogic loadAssetControlLogic;

	public bool hasStartInit;

	private PetCollectData petSelected;

	public ArenaReplayData ArenaReplayData;

	public Dictionary<string, Dictionary<ActionType, List<string>>> logs;

	public Dictionary<string, List<string>> damages;

	public CurrentBundlePackageRewardVisualInfo CurrentBundlePackageRewardVisualInfo;

	public PaymentResultSuccessInfo PaymentSucessPending;

	public bool hasLoseInDungeon;

	public bool isInTutorialArena;

	public bool isShopBlackFriday;

	public bool collectedSoulFromTombstone;

	public int battleCount;

	public bool IsInTutorial
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int BattleCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsPaused => false;

	public void Reset()
	{
	}

	public void SetEnableNotiAskForRate(bool enable)
	{
	}

	public bool IsEnableNotiAskForRate()
	{
		return false;
	}

	public void SetEnableNotiAskForSave(bool enable)
	{
	}

	public bool IsEnableNotiAskForSave()
	{
		return false;
	}

	public void SetCurrentAdventureDungeon(int dungeonId)
	{
	}

	public int GetCurrentAdventureDungeonEnter()
	{
		return 0;
	}

	public void SetCurrentBloodyDungeon(int dungeonId)
	{
	}

	public int GetCurrentBloodyDungeonEnter()
	{
		return 0;
	}

	public void SetCurrentRaidDungeon(int dungeonId)
	{
	}

	public int GetCurrentRaidDungeon()
	{
		return 0;
	}

	public void SetCurrentDailyChallengeDungeon(int dungeonId)
	{
	}

	public int GetCurrentDailyChallengeDungeon()
	{
		return 0;
	}

	public void SetCurrentScene(string sceneType)
	{
	}

	public string GetCurrentScene()
	{
		return null;
	}

	public void SetCurrentInventory(AbstractInventoryView inventoryView)
	{
	}

	public AbstractInventoryView GetCurrentInventory()
	{
		return null;
	}

	public void SetCachePopup(Type type, GameObject obj)
	{
	}

	public GameObject GetCachePopup(Type type)
	{
		return null;
	}

	public ConfigManager GetConfigManager()
	{
		return null;
	}

	public void ObtainNewEquipment(EquipmentConfigId equipmentConfig)
	{
	}

	public void ObtainNewPet(PetConfigId petConfigId)
	{
	}

	public void SetHasSeenEquipmentWithCategory(EquipmentCategory category)
	{
	}

	public bool HasObtainNewEquipentWithCategory(EquipmentCategory category)
	{
		return false;
	}

	public void SetEnableCheckLevelUpPackage(bool enable)
	{
	}

	public bool IsEnableCheckLevelUpPackage()
	{
		return false;
	}

	public void SetInLoadingScene(bool isInLoadingScene)
	{
	}

	public bool IsInLoadingScene()
	{
		return false;
	}

	public void SetHasShowSubsciptionPackage(bool hasShow)
	{
	}

	public bool HasShowSubsciptionPackage()
	{
		return false;
	}

	public void SetIsFirstTimeLogin(bool isFirstTime)
	{
	}

	public bool IsFirstTimeLogin()
	{
		return false;
	}

	public void SetIsPaused(bool isPaused)
	{
	}

	public FacebookSocial InitSocial()
	{
		return null;
	}

	public void CacheCamera(Camera camera)
	{
	}

	public List<Camera> GetCameras()
	{
		return null;
	}

	public void RemoveCacheCamera(Camera camera)
	{
	}

	public void SetHasSeenRuneWithType(Ssar.Rune.Model.RuneType type)
	{
	}

	public bool HasObtainNewRune(Ssar.Rune.Model.RuneType category)
	{
		return false;
	}

	public void ObtainNewRune(Rune rune)
	{
	}

	public bool HasObtainNewCraftingMaterial()
	{
		return false;
	}

	public void ObtainNewCraftingMaterial()
	{
	}

	public void SetHasSeenCraftingMaterial()
	{
	}

	public IBattleModeLogic GetBattleModeLogic()
	{
		return null;
	}

	public void SetBattleModeLogic(IBattleModeLogic _battleModeLogic)
	{
	}

	public void SetCharacterEquipmentGenerateLogic(AbsCharacterGenerateEquipmentLogic absCharacterGenerateEquipmentLogic)
	{
	}

	public AbsCharacterGenerateEquipmentLogic GetCharacterGenerateEquipmentLogic()
	{
		return null;
	}

	public BuyCharacterParameter GetBuyCharacterParameter()
	{
		return null;
	}

	public void SetBuyCharacterParameter(BuyCharacterParameter parameter)
	{
	}

	public void SetLoadAssetsControlLogic(AbsLoadAssetControlLogic logic)
	{
	}

	public AbsLoadAssetControlLogic GetLoadAssetControlLogic()
	{
		return null;
	}

	public T GetConfig<T>() where T : IConfig
	{
		return default(T);
	}

	public bool IsUsedBoostItem(BoostItemType type, BattleMode battleMode)
	{
		return false;
	}

	public void SetUseBoostItem(BoostItemType BoostItemType, bool isUse)
	{
	}

	private string GetKeyPrefOfBoostItem(BoostItemType boostItemType)
	{
		return null;
	}

	public void SelectPet(PetCollectData petCollectData)
	{
	}

	public void UnSelectPet()
	{
	}

	public PetCollectData GetCurrentPetSelected()
	{
		return null;
	}
}
