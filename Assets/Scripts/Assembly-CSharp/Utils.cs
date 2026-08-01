using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Utils;
using LitJson;
using SSAR.Dungeon.HUD;
using SSAR.Dungeon.View;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.View;
using Scripts.Config;
using Scripts.Config.Stats;
using Scripts.Ssar.Pet;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using Ssar.Rune.Model;
using UnityEngine;

public static class Utils
{
	private class CameraData
	{
		public string layer;

		public string path;

		public CameraData(string layer, string path)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckInternetConnectionIE_003Ed__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<bool> action;

		private WWW _003Cwww_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCheckInternetConnectionIE_003Ed__127(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayReenableObject_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject o;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayReenableObject_003Ed__45(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadModel_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadModelLogic logic;

		public object characterObject;

		public Action<GameObject> callBack;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadModel_003Ed__51(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CResetUIPopup_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public GameObject o;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CResetUIPopup_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const int DAILY_SAVE_LIMITED = 3;

	public const int DAILY_LOAD_LIMITED = 3;

	public const char UNDERSCORE_CHAR = '_';

	public const string UNDERSCORE_STRING = "_";

	public const string BODY_SURFACE_NAME = "body";

	public const string WEAPON_SURFACE_NAME = "weapon";

	public const string HEAD_SURFACE_NAME = "head";

	private static float UI_TO_MODEL_Z_;

	private static GameObject mainCharacterModelRoot;

	private static GameObject mainCharacterModelRoot2;

	private static Dictionary<PopupCamera, GameObject> cameraList;

	private static Dictionary<string, INGUIAtlas> dictAtlas;

	private static MethodInfo method;

	private static HUDConfig hudConfig;

	private static readonly List<string> deviceTest;

	public static (int start, int end, int adjustment)[] DungeonIdAdjustments;

	private static System.Random rng;

	private static StringBuilder stringBuilder;

	public static List<Vector2> MiddleRaysBetweenTwoRays(Vector2 ray1, Vector2 ray2, int middleCount)
	{
		return null;
	}

	public static List<Vector2> GenerateSymetricRaysFollowDirection(Vector2 direction, float angleStep, int rayCount)
	{
		return null;
	}

	public static void InitTest()
	{
	}

	public static bool IsTester()
	{
		return false;
	}

	public static EntityAbilities TransferData(ref EntityAbilities ret, AbsTransferDataParameter parameter)
	{
		return null;
	}

	public static object GetPropertyValue(PropertyInfo pInfo, object source)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResetUIPopup_003Ed__22))]
	public static IEnumerator ResetUIPopup(GameObject o, float time)
	{
		return null;
	}

	public static string GetMapName(MapInfo mapInfo)
	{
		return null;
	}

	public static string GetNodeName(Dungeon dungeon)
	{
		return null;
	}

	public static int GetMapID(Dungeon dungeon)
	{
		return 0;
	}

	public static int GetNodeID(Dungeon dungeon)
	{
		return 0;
	}

	public static string GetDifficultyName(ScenarioDifficulty difficulty)
	{
		return null;
	}

	public static string GetNodeDescription(Dungeon dungeon)
	{
		return null;
	}

	public static Texture GetMapBg(int mapId)
	{
		return null;
	}

	public static string GetBloodyTowerFloorName(BloodyTowerFloorInfo floor)
	{
		return null;
	}

	public static GameObject[] ReplaceCharacterChestArmor(int groupId, int subId, ref GameObject instance, CharacterVisualInfo chestArmor, CharacterVisualInfo cosmeticChestArmor, EquipmentVisualConfig equipmentConfig, bool isShowOff = true)
	{
		return null;
	}

	public static void ReplaceCharacterHelmet(int groupId, int subId, ref GameObject instance, CharacterVisualInfo helmet, CharacterVisualInfo cosmeticHelmet, EquipmentVisualConfig equipmentConfig, bool isShowOff = true)
	{
	}

	public static void ReplaceCharacterWeapon(int groupId, int subId, ref GameObject instance, CharacterVisualInfo weapon, CharacterVisualInfo cosmeticWeapon, EquipmentVisualConfig equipmentConfig, bool isShowOff = true)
	{
	}

	public static void ReplaceWing(int groupId, int subId, ref GameObject o, CharacterVisualInfo characterVisualInfo, EquipmentVisualConfig equipmentConfig, ResourcesLoader resourcesLoader)
	{
	}

	private static GameObject RepalceSkinnedMesh(string path, string surfaceName, ref GameObject instance, bool isShowOff)
	{
		return null;
	}

	private static void ReplaceFx(string surfaceName, GameObject newInstance, ref GameObject instance, bool isShowOff)
	{
	}

	private static GameObject ReplaceSurface(string surfaceName, GameObject newInstance, ref GameObject instance)
	{
		return null;
	}

	private static void UpdateBones(SkinnedMeshRenderer skinnedMeshRenderer, GameObject root)
	{
	}

	public static void MoveToTransformAndChangeLayer(GameObject transform, GameObject parent)
	{
	}

	public static void ScaleParticleInChildren(Transform transform, float scale)
	{
	}

	public static string GetEquipmentVisualPath(int groupId, int subId, EquipmentType equipmentType, int visualId, Rarity rarity, EquipmentVisualConfig equipmentConfig)
	{
		return null;
	}

	public static Transform FindDeepChild(this Transform aParent, string aName, bool findRoot = false)
	{
		return null;
	}

	public static Transform FindRootJoint(Transform root)
	{
		return null;
	}

	public static void LoadModelReview(MainCharacterData mainCharacterData, EquipmentVisualConfig equipmentVisualConfig, ResourcesLoader resourcesLoader, Action<GameObject> callBack, LoadModelLogic logic)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayReenableObject_003Ed__45))]
	public static IEnumerator DelayReenableObject(GameObject o)
	{
		return null;
	}

	public static void LoadModelReview(int groupId, int subId, DisplayCharacterInfo info, LoadModelLogic logic, Action<GameObject> callBack, ResourcesLoader resourcesLoader, EquipmentVisualConfig equipmentConfig)
	{
	}

	public static void LoadModelReview(int groupId, int subId, LoadModelLogic logic, Action<GameObject> callBack)
	{
	}

	public static void ClearModel()
	{
	}

	public static void ClearModel(GameObject modelRoot)
	{
	}

	public static string GetCharacterName(HeroBasicStats basicStats)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadModel_003Ed__51))]
	private static IEnumerator LoadModel(object characterObject, LoadModelLogic logic, Action<GameObject> callBack)
	{
		return null;
	}

	private static GameObject Instantiate(object characterObject, LoadModelLogic logic)
	{
		return null;
	}

	public static void AnchorUIAndModelPosition(GameObject UI, GameObject model)
	{
	}

	public static GameObject GetCharacterModelRoot()
	{
		return null;
	}

	public static GameObject GetCharacterModelRoot2()
	{
		return null;
	}

	public static UserResourcesView InstantiateUserResourcesView(InstantiateUserResourcesParameter parameter)
	{
		return null;
	}

	public static void GetIconResources(ConfigManager configManager, ItemType type, ref UISprite sprite, int configId = -1)
	{
	}

	public static string GetRandomEquipmentCardIcon(EquipmentType equipmentCategory, List<EquipmentType> types, List<Rarity> rarities)
	{
		return null;
	}

	public static string GetRandomEquipmentCardName(ConfigManager configManager, int randomEquipmentConfigId)
	{
		return null;
	}

	public static void GetRandomEquipmentCardName(ConfigManager configManager, int randomEquipmentConfigId, ref UILabel label)
	{
	}

	public static Rarity GetRandomEquipmentMinRarity(ConfigManager configManager, int randomEquipmentConfigId)
	{
		return default(Rarity);
	}

	public static void ResizeIconResources(ItemType type, int boxSize, ref UISprite sprite)
	{
	}

	public static UIAtlas GetAtlasElement()
	{
		return null;
	}

	public static UIAtlas GetUIInterface()
	{
		return null;
	}

	public static UIAtlas GetShopAtlas()
	{
		return null;
	}

	public static UIAtlas GetAtlas(string atlasPath)
	{
		return null;
	}

	public static INGUIAtlas GetAtlas(string spriteName, string atlasName, INGUIAtlas atlas)
	{
		return null;
	}

	public static bool AtlasContainsSprite(string grade, string atlasName, INGUIAtlas atlas)
	{
		return false;
	}

	public static void GetEquipmentName(EquipmentConfigId equipmentConfigId, int groupId, ref UILabel label)
	{
	}

	public static void GetEquipmentName(string name, Rarity rarity, ref UILabel label)
	{
	}

	public static string GetEquipmentName(EquipmentConfigId equipmentConfigId, int groupId)
	{
		return null;
	}

	public static void GetEquipmentBgRarity(Rarity rarity, ref UISprite sprite)
	{
	}

	public static string GetEquipmentBgRaritySpriteName(Rarity rarity)
	{
		return null;
	}

	public static void GetEquipmentRarityTitle(Rarity rarity, ref UILabel label)
	{
	}

	public static string GetEquipmentRarityTitle(Rarity rarity)
	{
		return null;
	}

	public static HUDTextInfo GetTextInfo(Rarity rarity)
	{
		return null;
	}

	public static string GetEquipmentTierTitle(EquipmentTier tier, bool useBBCode = true)
	{
		return null;
	}

	public static void GetEquipmentIcon(int groupId, int subId, EquipmentConfigId equipmentConfigId, ref UISprite sprite, bool isCraftMode = false)
	{
	}

	public static void GetEquipmentIcon(string icon, Rarity rarity, ref UISprite sprite)
	{
	}

	public static void GetEquipmentIcon3D(int groupId, int subId, EquipmentConfigId equipmentConfigId, out string spriteName, out INGUIAtlas atlas)
	{
		spriteName = null;
		atlas = null;
	}

	public static string GetEquipmentIconSpriteName(int groupId, int subId, EquipmentConfigId equipmentConfigId)
	{
		return null;
	}

	public static string GetEquipmentIconSpriteName(string icon, Rarity rarity)
	{
		return null;
	}

	public static void GetEquipmentSlotIconDefault(EquipmentType type, Rarity rarity, ref UISprite sprite)
	{
	}

	public static void GetEquipmentSlotIconDefault(EquipmentType type, ref UISprite sprite)
	{
	}

	public static string GetEquipmentCategoryTitle(EquipmentCategory category)
	{
		return null;
	}

	public static string GetEquipmentCombinedTypeTitle(EquipmentCombinedType category)
	{
		return null;
	}

	public static string GetStatTypeLocalize(StatType statType)
	{
		return null;
	}

	private static HUDConfig GetHudConfig()
	{
		return null;
	}

	public static string SubstatValueFormat(StatType type, double value)
	{
		return null;
	}

	public static string GetEquipmentSkillName(EquipmentSkillInfo info, HeroConfig heroConfig)
	{
		return null;
	}

	public static string GetEquipmentSkillDesc(EquipmentSkillInfo info, HeroConfig heroConfig, JsonEquipmentDropConfig jsonEquipmentDropConfig)
	{
		return null;
	}

	public static string GetEquipmentSkillLv(EquipmentSkillInfo info, HeroConfig heroConfig)
	{
		return null;
	}

	public static string GetEquipmentPassiveSkillName(EquipmentSkillInfo info)
	{
		return null;
	}

	public static string GetEquipmentPassiveSkillDesc(EquipmentSkillInfo info, int groupId, JsonEquipmentDropConfig equipmentDropConfig)
	{
		return null;
	}

	public static string GetEquipmentPassiveSkillLv(EquipmentSkillInfo info)
	{
		return null;
	}

	public static void GetEquipmentPassiveSkillIcon(EquipmentSkillInfo activeSkillStat, ref UISprite sprite)
	{
	}

	public static int GetEquipmentMaxReforgeCount(Rarity rarity)
	{
		return 0;
	}

	public static string GetActiveSkillName(ISkillStat activeSkillStat)
	{
		return null;
	}

	public static void GetActiveSkillIcon(ISkillStat activeSkillStat, ref UISprite sprite)
	{
	}

	public static string GetSkillName(ISkillStat skillStat)
	{
		return null;
	}

	public static void GetSkillIcon(ISkillStat skillStat, ref UISprite sprite)
	{
	}

	public static string GetSkillDescription(ISkillStat skillStat)
	{
		return null;
	}

	public static string GetSkillCategoryName(ISkillStat skillStat)
	{
		return null;
	}

	public static string GetRealMoneytext()
	{
		return null;
	}

	public static string LogPropertyValue(object obj, string ext = "")
	{
		return null;
	}

	public static string GetCharacterPrefabPath(int groupId, int id)
	{
		return null;
	}

	public static GameObject GetCamera(PopupCamera cameraType)
	{
		return null;
	}

	public static void ShowPanelWithNextDepth(UIPanel panel)
	{
	}

	private static int CalculateNextPanelDepth(GameObject go)
	{
		return 0;
	}

	private static UIPanel[] GetChildrenPanels(GameObject go)
	{
		return null;
	}

	public static GameObject AddChild(string path, GameObject parent)
	{
		return null;
	}

	public static void ResizeBaseOn(UISprite sprite, UIWidget.AspectRatioSource baseOn, int size)
	{
	}

	public static string NumberQuantityFormat(int number)
	{
		return null;
	}

	public static void GetModifierIcon(ModifierVisualType modifierType, ref UISprite sprite)
	{
	}

	public static void SetModifierIcon(string spriteName, ref UISprite sprite)
	{
	}

	public static ParticleRunAroundFx SpawnParticleRunAroundFx(GameObject parent)
	{
		return null;
	}

	public static ParticelRunCircle SpawnParticleRunCircleFx(GameObject parent)
	{
		return null;
	}

	public static GameObject InstantiateUIFx(EffectPathIndex pathIndex, GameObject parent, int panelDepthOffset = 3, bool updateRenderqueue = true)
	{
		return null;
	}

	public static bool checkPackageAppIsPresent(string package)
	{
		return false;
	}

	public static bool HasInstalledFbApp()
	{
		return false;
	}

	public static RewardReceiveView InstanteRewardReceiveView(GameObject parent)
	{
		return null;
	}

	public static ItemInfo ParseItemInfo2(ItemType type, int configId, int quantity)
	{
		return null;
	}

	public static ItemInfo ParseItemInfo2(string itemType, int configId, int quantity)
	{
		return null;
	}

	public static string GetAchievementDescription(JsonAchievementConfig.AchievementItem item)
	{
		return null;
	}

	public static string GetAchievementName(JsonAchievementConfig.AchievementItem item)
	{
		return null;
	}

	public static void CheckInternetConnection(Action<bool> action, string url = "http://google.com")
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInternetConnectionIE_003Ed__127))]
	public static IEnumerator CheckInternetConnectionIE(Action<bool> action, string url = "http://google.com")
	{
		return null;
	}

	public static string GetDeviceId()
	{
		return null;
	}

	public static GameObject CloneObjectKeepScale(GameObject parent, GameObject prefab)
	{
		return null;
	}

	public static GameObject CloneObjectClearComponent(GameObject parent, GameObject prefab)
	{
		return null;
	}

	public static void AnchorScale(GameObject trans, GameObject target)
	{
	}

	public static Vector3 GetScale(GameObject trans, GameObject target)
	{
		return default(Vector3);
	}

	public static void SetPosition(GameObject curObj, GameObject target)
	{
	}

	public static UIFont GetFontTahoma()
	{
		return null;
	}

	public static SimpleRewardView InstantiateRewardView(GameObject parent)
	{
		return null;
	}

	public static void ShowReward(ConfigManager configManager, ItemInfo itemInfo, UISprite sp_icon, UISprite sp_quality, UILabel lb_name, UILabel lb_quantity, UILabel lb_tier, GameObject wg_tier, UISprite[] skillIcon)
	{
	}

	public static void ShowEquipentkillIcon(UISprite[] skillIcon, EquipmentConfigId equipmentConfig, HeroConfig heroConfig)
	{
	}

	public static bool IsOlderVersion(string currentVersion, string version, ref bool error)
	{
		return false;
	}

	private static bool SeperateVersionInfo(string version, out int prefix, out int major, out int minor, out int patch)
	{
		prefix = default(int);
		major = default(int);
		minor = default(int);
		patch = default(int);
		return false;
	}

	public static void CheckAndSetNewService<T>(T val)
	{
	}

	public static T MapData<T>(JsonData data) where T : class
	{
		return null;
	}

	public static Dictionary<string, Dictionary<string, T>> MapJsonToDictionary<T>(string textJson, string ignoreDictionaryHasName = "") where T : class
	{
		return null;
	}

	public static void UpdateIcon(UISprite sp, string iconName, string atlasName)
	{
	}

	public static Mesh CreateMesh(float width, float height)
	{
		return null;
	}

	public static void GetCharacterAvatar(MainCharacterData mainCharacterData, ref UISprite sp)
	{
	}

	public static void GetCharacterAvatar(int groupdId, ref UISprite sp)
	{
	}

	public static string GetCharacterAvatarTexturename(int groupdId)
	{
		return null;
	}

	public static ButtonWatchAds InstantiateButtonWatchAds(GameObject parent, string buttonName, int vodRequire, Reason reason, Action onSuccess)
	{
		return null;
	}

	public static string FirstLetterUpcase(string text)
	{
		return null;
	}

	public static GameObject LoadGameObject(string resourcesPath)
	{
		return null;
	}

	public static T Load<T>(string resourcesPath) where T : UnityEngine.Object
	{
		return null;
	}

	public static T CreateInstance<T>(string nameSpace, string className, params object[] paramArray)
	{
		return default(T);
	}

	public static string AppURL()
	{
		return null;
	}

	public static IItemLogic GetIItemLogic(EnhanceItemType item)
	{
		return null;
	}

	public static float GetAspect()
	{
		return 0f;
	}

	public static Vector2 GetScreenSize()
	{
		return default(Vector2);
	}

	public static Vector2 GetMainGameViewSize()
	{
		return default(Vector2);
	}

	public static byte[] GetBytes(this string str)
	{
		return null;
	}

	public static string GetString(this byte[] bytes)
	{
		return null;
	}

	public static string MD5(string strToEncrypt)
	{
		return null;
	}

	public static string GetDailyQuestName(DailyQuestConfig.QuestItem questItem)
	{
		return null;
	}

	public static string GetDailyQuestDesc(DailyQuestConfig.QuestItem questItem)
	{
		return null;
	}

	public static void GetRuneBgRarity(RuneType runeType, RuneRarity rarity, ref UISprite sprite)
	{
	}

	public static string GetRuneBgRaritySpriteName(RuneType runeType, RuneRarity rarity)
	{
		return null;
	}

	public static void GetRuneIcon(Rune rune, ref UISprite sprite)
	{
	}

	public static void GetRuneIcon(RuneType runeType, RuneRarity runeRarity, ref UISprite sprite)
	{
	}

	public static string GetRuneIconSpriteName(RuneType runeType, RuneRarity runeRarity)
	{
		return null;
	}

	public static void GetRuneIcon3D(Rune rune, out string spriteName, out INGUIAtlas atlas)
	{
		spriteName = null;
		atlas = null;
	}

	public static string GetRuneName(RuneType runeType, RuneRarity runeRarity)
	{
		return null;
	}

	public static void GetRuneName(RuneType runeType, RuneRarity runeRarity, ref UILabel label)
	{
	}

	public static string GetRandomRuneCardIcon(RandomRuneConfig.RandomRune randomRune)
	{
		return null;
	}

	public static void GetRandomRuneCardName(ConfigManager configManager, int randomRuneConfigId, ref UILabel label)
	{
	}

	public static Rarity ConvertRarity(RuneRarity runeRarity)
	{
		return default(Rarity);
	}

	public static RuneRarity ConvertToRuneRarity(Rarity rarity)
	{
		return default(RuneRarity);
	}

	public static string GetRandomRuneCardName(ConfigManager configManager, int randomRuneConfigId)
	{
		return null;
	}

	public static RuneRarity GetRandomRuneMinRarity(ConfigManager configManager, int randomRuneConfigId)
	{
		return default(RuneRarity);
	}

	public static void GetPetName(PetConfigId petConfigId, ref UILabel label)
	{
	}

	public static string GetPetName(PetConfigId petConfigId)
	{
		return null;
	}

	public static void GetPettIcon(PetConfigId PetConfigId, ref UISprite sprite)
	{
	}

	public static string GetPetIconSpriteName(PetConfigId PetConfigId)
	{
		return null;
	}

	public static void GetPetIcon3D(PetConfigId petConfigId, out string spriteName, out INGUIAtlas atlas)
	{
		spriteName = null;
		atlas = null;
	}

	public static void GetPetBgRarity(Rarity rarity, ref UISprite sp_bg)
	{
	}

	public static string GetRandomPetCardName(ConfigManager configManager, int randomPetconfigid, ref UILabel label)
	{
		return null;
	}

	public static string GetRandomPetCardName(ConfigManager configManager, int randomEquipmentConfigId)
	{
		return null;
	}

	public static Rarity GetRandomPetMinRarity(ConfigManager configManager, int randomPetConfigId)
	{
		return default(Rarity);
	}

	public static string GetRandomPetCardIcon(RandomPet randomRune)
	{
		return null;
	}

	public static string GetPetSlotIconDefault()
	{
		return null;
	}

	public static void GetPetSlotIconDefault(ref UISprite sprite)
	{
	}

	public static void GetMaterialBgRarity(CraftingMaterialType type, Rarity rarity, ref UISprite sprite)
	{
	}

	public static string GetMaterialBgRaritySpriteName(CraftingMaterialType type, Rarity rarity)
	{
		return null;
	}

	public static void GetMaterialIcon(CraftingMaterial material, ref UISprite sprite)
	{
	}

	public static void GetMaterialIcon(CraftingMaterialType type, Rarity rarity, ref UISprite sprite)
	{
	}

	public static string GetMaterialIconSpriteName(CraftingMaterialType type, Rarity rarity)
	{
		return null;
	}

	public static void GetMaterialIcon3D(CraftingMaterial material, out string spriteName, out INGUIAtlas atlas)
	{
		spriteName = null;
		atlas = null;
	}

	public static string GetMaterialName(CraftingMaterialType type, Rarity rarity)
	{
		return null;
	}

	public static void GetMaterialName(CraftingMaterialType type, Rarity rarity, ref UILabel label)
	{
	}

	public static void GetMaterialName(ConfigManager configManager, int configID, ref UILabel label)
	{
	}

	public static void Shuffle<T>(this IList<T> list)
	{
	}

	public static T GetCopyOf<T>(this Component comp, T other) where T : Component
	{
		return null;
	}

	public static T InstantiatePrefab<T>(string path, GameObject parent) where T : MonoBehaviour
	{
		return null;
	}

	public static int Random(int[] singletons, float[] probabilities)
	{
		return 0;
	}

	public static void InitRandomSeed(int randomSeed)
	{
	}

	public static float RandomRange(float min, float max)
	{
		return 0f;
	}

	public static int RandomRange(int min, int max)
	{
		return 0;
	}

	public static bool RandomHit(float rate)
	{
		return false;
	}

	public static ShortCutFindItem InstantiateShortCutFindItem(UIWidget widget)
	{
		return null;
	}

	public static string UppercaseWords(string value)
	{
		return null;
	}

	public static string GetGroupSubSkillId(int groupId, int subId, int skillId = -1)
	{
		return null;
	}

	public static string GetGooglePlayOrderId(string receipt, string defaultId)
	{
		return null;
	}
}
