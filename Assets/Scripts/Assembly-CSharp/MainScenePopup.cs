using UnityEngine;

public class MainScenePopup : BasePopup
{
	public interface Condition
	{
		bool IsSatisfyingConditions();
	}

	public class DefaultCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class PiggyBankCondition : Condition
	{
		private readonly PiggyBankType piggyBankType;

		public PiggyBankCondition(PiggyBankType piggyBankType)
		{
		}

		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class HotDealCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class LevelUpCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class FirstTopUpCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class SubscribeCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class AncientCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class AccessoryCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class PetCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class RuneCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class DoubleExpCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class VendorCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	private class FlashSaleCondition : Condition
	{
		public bool IsSatisfyingConditions()
		{
			return false;
		}
	}

	public GameObject modelRoot;

	public GameObject btn_skill;

	public GameObject btn_equipment;

	public GameObject btn_adventure;

	public GameObject btn_challenge;

	public GameObject btn_shopResources;

	public GameObject btn_shopTreasure;

	public GameObject btn_shopVendor;

	public GameObject resources_container;

	public GameObject btn_rune;

	public GameObject btn_firstTime;

	public GameObject btn_hotdeal;

	public GameObject btn_levelUpPackage;

	public GameObject btn_subscribePackage;

	public GameObject btn_cosmeticGallery;

	public GameObject btn_switch;

	public GameObject btn_crossPromotion;

	public GameObject btn_mastery;

	public GameObject btn_piggyBank;

	public GameObject btn_petList;

	public GameObject btn_craft;

	public GameObject btn_questGroup;

	public GameObject btn_runePack;

	public GameObject btn_petPack;

	public GameObject btn_event;

	public GameObject btn_xmasOnline;

	public GameObject btn_crystalPiggyBank;

	public GameObject btn_doubleExp;

	public GameObject btn_flashSale;

	public GameObject btn_ancientPack;

	public GameObject btn_accessoryPack;

	public GameObject btn_7dayCampaign;

	public GameObject btn_demonLogin;

	public GameObject btn_demonInvasion;

	public GameObject btn_dailyReward;

	public GameObject btn_community;

	public GameObject btn_unlockAllCharactersPackage;

	public GameObject btn_flashSaleOreRuneBundle;

	public GameObject btn_blackFridaySale;

	public GameObject btn_eventPopup;

	public UITable packContainer;

	private float time;

	// Minimal implementation: this hub screen genuinely has ~40 buttons
	// covering shop/events/notifications/daily-login/pets/mastery/rune/
	// craft/piggy-bank/etc, almost all monetization- or event-adjacent and
	// out of scope. Only btn_adventure (-> Adventure(), the actual "go
	// play" button) is wired; everything else is left inert on purpose so
	// the hub is visible and navigable without pretending those systems
	// exist.
	protected override void Awake()
	{
		base.Awake();
		InitResourcesBar();
		InitFxButtonAdventure(btn_adventure);
		InitFxButtonChallenge(btn_challenge);
	}

	private void SendShopClickObject(string nameItem)
	{
	}

	private void OnHidePopup(BasePopup obj, bool showAnotherPopup)
	{
	}

	private void Community(GameObject go)
	{
	}

	private void Campaign(GameObject go)
	{
	}

	private void ShowAccessory(GameObject go)
	{
	}

	private void ShowAncient(GameObject go)
	{
	}

	private void EventDemonInvasion(GameObject go)
	{
	}

	private void DailyReward(GameObject go)
	{
	}

	private void FlashSale(GameObject go)
	{
	}

	private void DoubleExp(GameObject go)
	{
	}

	private void CrystalPiggyBank(GameObject go)
	{
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		Show();

		if (btn_adventure != null)
		{
			UIEventListener.Get(btn_adventure).onClick -= Adventure;
			UIEventListener.Get(btn_adventure).onClick += Adventure;
		}
	}

	private void Event(GameObject go)
	{
	}

	private void XmasOnline(GameObject go)
	{
	}

	private void PetPack(GameObject go)
	{
	}

	private void RunePack(GameObject go)
	{
	}

	private void ShowQuestGroup(GameObject go)
	{
	}

	private void Craft(GameObject go)
	{
	}

	private void AnniversaryQuet(GameObject o)
	{
	}

	private void AnniversaryLogin(GameObject o)
	{
	}

	private void Pet(GameObject go)
	{
	}

	private void Piggy(GameObject go)
	{
	}

	private void Switch(GameObject go)
	{
	}

	private void ShowCosmeticGallery(GameObject go)
	{
	}

	private void Subscribe(GameObject go)
	{
	}

	private void ShowHotDeal(GameObject go)
	{
	}

	private void SendShopAndIapClickHotDeal()
	{
	}

	private void ShowFirstTimePopup(GameObject go)
	{
	}

	private void SendShopAndIapClickFirstTimePurchase()
	{
	}

	private void ShowUnlockAllCharacters(GameObject go)
	{
	}

	private void ShowFlashSaleOreRuneBundle(GameObject go)
	{
	}

	private void ShowShopBlackFridaySale(GameObject go)
	{
	}

	private void ShowEventPopup(GameObject go)
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void onEnable()
	{
	}

	protected override void ExecuteBack()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show()
	{
		NGUITools.SetActive(gameObject, true);
	}

	private void SortPackages()
	{
	}

	private void LimitPackages()
	{
	}

	public void CheckUnLockPiggy()
	{
	}

	// resources_container is a real field wired to a real (but empty -
	// built at runtime, not baked into the prefab) Container GameObject.
	// The real widget is UserResourceBar.prefab (Resources/guiprefabs/),
	// carrying the level/name/exp display plus the stamina/video/
	// crystal/soul currency row.
	private void InitResourcesBar()
	{
		if (resources_container == null)
		{
			return;
		}

		GameObject prefab = Resources.Load<GameObject>("guiprefabs/UserResourceBar");
		if (prefab == null)
		{
			Debug.LogError("[MainScenePopup] Could not load prefab at Resources/guiprefabs/UserResourceBar");
			return;
		}

		GameObject instance = Object.Instantiate(prefab, resources_container.transform, worldPositionStays: false);
		SSAR.View.UserResourcesView view = instance.GetComponent<SSAR.View.UserResourcesView>();
		if (view != null)
		{
			InstantiateUserResourcesParameter parameter = new InstantiateUserResourcesParameter(
				resources_container, UserResourcesLeftCornerType.User, null, null);
			view.Init(parameter);
		}
	}

	private void InitModelRoot()
	{
	}

	public void CheckEnableFirstTopUp()
	{
	}

	private void OpenSkill(GameObject o)
	{
	}

	private void OpenEquipment(GameObject o)
	{
	}

	// The real handoff point: from here the real game presumably goes
	// through character/stage selection (SelectionScene, a separate branch
	// of this reconstruction) before actually starting a dungeon. Loads
	// SelectionScene directly; DungeonSelection's defaults mean a dungeon
	// can still be started even before that scene's own UI is wired up.
	private void Adventure(GameObject o)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(Assets.Scripts.Utils.SceneName.SELECTION_SCENE);
	}

	private void Challenge(GameObject o)
	{
	}

	private void ShopResources(GameObject o)
	{
	}

	private void ShopVendor(GameObject o)
	{
	}

	private void ShopTreasure(GameObject o)
	{
	}

	// Real flame+spark decoration prefabs (fragment/smoke/fire/buttonLight
	// particle children) - IL2CPP metadata confirms these two methods were
	// already empty in the original compiled game too (no logic to
	// recover), so which exact prefab maps to which button is inferred
	// rather than known - two real variants exist (fx/fx2), assigned one
	// per button.
	private void InitFxButtonAdventure(GameObject o)
	{
		InstantiateButtonFx(o, "effect/ui/misc/Challenge_btn_fx");
	}

	private void InitFxButtonChallenge(GameObject o)
	{
		InstantiateButtonFx(o, "effect/ui/misc/Challenge_btn_fx2");
	}

	private void InstantiateButtonFx(GameObject button, string resourcePath)
	{
		if (button == null)
		{
			return;
		}
		GameObject prefab = Resources.Load<GameObject>(resourcePath);
		if (prefab == null)
		{
			Debug.LogError("[MainScenePopup] Could not load prefab at Resources/" + resourcePath);
			return;
		}
		Object.Instantiate(prefab, button.transform, worldPositionStays: false);
	}

	private void ShowMemoryShard(GameObject o)
	{
	}

	private void ShowRune(GameObject o)
	{
	}

	private void ClickBack()
	{
	}

	private void LevelUp(GameObject o)
	{
	}

	private void ClickCrossPromotion(GameObject o)
	{
	}

	private void Mastery(GameObject o)
	{
	}

	private void CheckUnlockFeature(GameObject btn, FeatureName featureName, Condition condition)
	{
	}

	private void CheckUnlockQuest()
	{
	}

	private void CheckUnlockEvent()
	{
	}

	private void EventDemonLogin(GameObject go)
	{
	}

	private void CheckUnlockDemonInvasion()
	{
	}

	private void CheckUnlockXmasOnline()
	{
	}

	public void CheckUnlockAllCharactersPackage()
	{
	}

	public void CheckUnlockShowFlashSaleOreRuneBundle()
	{
	}

	private void CheckUnlockFlashSale()
	{
	}

	private void CheckUnlockVendor()
	{
	}

	private void CheckUnlockCampaign()
	{
	}

	private void CheckUnlockShopBlackFriday()
	{
	}

	private void CheckUnlockEventPopup()
	{
	}

	private void Update()
	{
	}
}
