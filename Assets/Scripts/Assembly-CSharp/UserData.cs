using System.Collections.Generic;
using Assets.Scripts.Ssar.AdMob.Interstitial;
using Assets.Scripts.Ssar.DataManager;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.Entry.Model;
using Ssar.Database.Compressor;

public class UserData
{
	public int currentSelectCharacter;

	public int lasTimeSaved;

	public int lastTimeLoaded;

	public int todaySaveAvailable;

	public int todayLoadAvailable;

	public int lasTimePlayed;

	public string userId;

	public string fireBaseUserId;

	public List<MainCharacterData> MainCharacterCollectDatas;

	public List<string> transactionIdsOfReceipts;

	public string lastVersionPlayed;

	public int lastTimeCheckNewDay;

	public List<PurchasedProduct> validPurchasedProducts;

	public string lastDeviceId;

	public int lastTimeShowAskForSave;

	[JsonInclude]
	private ObscuredInt skillPointPurchasedObscuredInt;

	[JsonInclude]
	private bool hasRateApp;

	[JsonInclude]
	private int numberofCloseRatePopUp;

	[JsonInclude]
	private Dictionary<string, bool> ratingDict;

	[JsonInclude]
	private UserDataType type;

	[JsonInclude]
	private List<UserDataType> linked;

	public NotificationData notificationData;

	[JsonInclude]
	private bool hasUseNewLogin;

	[JsonInclude]
	private UserCompressedData compressedData;

	[JsonInclude]
	private UserPurchaseCompactedData purchaseCompactedData;

	public List<int> characterCanCreateFree;

	public InterstitialData interstitialData;

	[JsonIgnore]
	public int skillPointPurchased
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public List<string> TransactionIdsOfReceipts => null;

	public UserData InitData()
	{
		return null;
	}

	public void AddCharacter(MainCharacterData mainCharacterData)
	{
	}

	public void SetSelectCharacter(int characterId)
	{
	}

	public MainCharacterData GetMainCharacterData(int id)
	{
		return null;
	}

	public MainCharacterData GetCurrentCharacterData()
	{
		return null;
	}

	public bool FindCharacterWithGroupId(int groupId, int subId, ref MainCharacterData mainCharacterData)
	{
		return false;
	}

	public void AddTransactionId(string id)
	{
	}

	public string GetUserId()
	{
		return null;
	}

	public void SetLastTimePlayed(int timeInSecond)
	{
	}

	public int GetLastTimePlayed()
	{
		return 0;
	}

	public void AddValidPurchasedProduct(PurchasedProduct pp)
	{
	}

	public void RateApp()
	{
	}

	public void UnRateApp()
	{
	}

	public void IncreaseNumberOfClosingRatePopUp()
	{
	}

	public int GetNumberOfClosingRatePopUp()
	{
		return 0;
	}

	public bool IsOpenedRatePopUpAtDungeon(int nodeId)
	{
		return false;
	}

	public void SetRatePopUpDict()
	{
	}

	public int SetNumberOfClosingRatePopUp(int num)
	{
		return 0;
	}

	public bool HasRateApp()
	{
		return false;
	}

	public void DeleteCharacter(MainCharacterData mainCharacterData)
	{
	}

	public bool IsUseNewLogin()
	{
		return false;
	}

	public void SetUsedNewLogin()
	{
	}

	public UserDataType GetUserType()
	{
		return default(UserDataType);
	}

	public void SetUserType(UserDataType type)
	{
	}

	public bool HasLinkWith(UserDataType type)
	{
		return false;
	}

	public void LinkDataTo(UserDataType type)
	{
	}

	public void SetFirebaseUID(string firebaseUID)
	{
	}

	public UserCompressedData GetCompressedData()
	{
		return null;
	}

	public UserPurchaseCompactedData GetPurchaseCompactedData()
	{
		return null;
	}
}
