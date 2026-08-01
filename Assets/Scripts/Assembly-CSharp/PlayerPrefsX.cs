using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsX
{
	private enum ArrayType
	{
		Float = 0,
		Int32 = 1,
		Bool = 2,
		String = 3,
		Vector2 = 4,
		Vector3 = 5,
		Quaternion = 6,
		Color = 7
	}

	public static readonly string LAST_TIME_SHOW_DAILYLOGIN;

	public static readonly string USE_HP_POTION;

	public static readonly string USE_EXP_TICKET;

	public static readonly string USE_SOUL_TICKET;

	public static readonly string USE_AUTO_TICKET;

	public static readonly string MUTE_SOUND;

	public static readonly string MUTE_MUSIC;

	public static readonly string CACHE_CHANGE_LANGUAGE;

	public static readonly string LEVELUP_PACKAGE_SKIP_FOR_TODAY;

	public static readonly string LAST_TIME_SHOW_BUNDLE_PACAKGE_THREE_PRODUCT;

	public static readonly string FPS;

	public static readonly string DISABLE_NOTI;

	public static readonly string DISABLE_DAMAGE_TEXT;

	public static readonly string DISABLE_DEATH_EFFECTS;

	public static readonly string LAST_TIME_SHOW_BUNDLE_PACKAGE_ONE_PRODUCT;

	public static readonly string BUNDLE_PACKAGE_ONE_PRODUCT_SKiP_FOR_TODAY;

	public static readonly string BUNDLE_PACKAGE_THREE_PRODUCT_SKIP_FOR_TODAY;

	public static readonly string LAST_TIME_LOAD_DATA;

	public static readonly string LAST_VERSION_PLAY;

	public static readonly string SKIP_DUNGEON_WIN_BONUS;

	public static readonly string LAST_TIME_SHOW_DUNGEON_WIN_BONUS;

	public static readonly string MAIN_SCENE_BUTTON_CHALLENGE_NOTIFY;

	public static readonly string CHALLENGE_MAP_BUTTON_BLOODYTOWER_NOTIFY;

	public static readonly string HAS_VIEW_SUBSCRIBE_PACAKGE;

	public static readonly string LAST_PRODUCT_ID_OF_LEVELUP_PACKAGE_VIEW;

	public static readonly string LAST_TIME_SHOW_ASK_FOR_RATE;

	public static readonly string HAS_INIT_LANGUAGE;

	public static readonly string LAST_TIME_SHOW_BUNDLE_PACAKGE_IN_SCENE;

	public static readonly string CLICK_RUNE_PACK;

	public static readonly string CHALLENGE_MAP_BUTTON_RAID_NOTIFY;

	public static readonly string CHALLENGE_MAP_BUTTON_DAILY_NOTIFY;

	public static readonly string CLICK_PET_PACK;

	public static readonly string CLICK_ANCIENT_PACK;

	public static readonly string CLICK_ACCESSORY_PACK;

	public static readonly string FB_TOKEN;

	public static readonly string SHOW_DOUBLE_EXP_PACKAGE;

	public static readonly string LAST_TIME_SHOW_DOUBLE_PACKAGE_VALUE_EVENT_BANNER;

	public static readonly string LAST_TIME_SHOW_XMAST_EVENT_BANNER;

	public static readonly string LAST_TIME_SHOW_CAMPAIGN;

	public static readonly string LAST_TIME_SHOW_SUBCRIBE_PACKAGE;

	public static readonly string LAST_TIME_SHOW_EVENT_WAR;

	public static readonly string DEATH_PENALTY_FULL_WARNING_ENABLE;

	public const string UNLOCK_ALL_CHARACTERS_PACKAGE = "unlockAllCharactersPackage";

	public const string HAS_VIEW_UNLOCK_ALL_CHARACTERS_PACKAGE = "hasShowUnlockAllCharactersPackage";

	public const string HAS_VIEW_FLASH_SALE_ORE_RUNE_BUNDLE = "hasShowFlashSaleOreRuneBundle";

	public const string LAST_TIME_SHOW_SHOP_BLACK_FRIDAY = "lastTimeShowShopBlackFriday";

	private static int endianDiff1;

	private static int endianDiff2;

	private static int idx;

	private static byte[] byteBlock;

	private static string keyString;

	private static string privateKey;

	public static string[] keys;

	public static void SetPrivateKey(string key)
	{
	}

	public static void SaveEncryption(string key, string type, string value)
	{
	}

	public static bool CheckEncryption(string key, string type, string value)
	{
		return false;
	}

	public static bool HasKey(string key)
	{
		return false;
	}

	public static void DeleteKey(string key)
	{
	}

	public static List<string> GetAllKeys()
	{
		return null;
	}

	public static bool SetBool(string name, bool value)
	{
		return false;
	}

	private static bool GetBool(string name)
	{
		return false;
	}

	public static bool GetBool(string name, bool defaultValue)
	{
		return false;
	}

	public static bool SetInt(string name, int value)
	{
		return false;
	}

	private static int GetInt(string name)
	{
		return 0;
	}

	public static int GetInt(string name, int defaultValue)
	{
		return 0;
	}

	public static bool SetFloat(string name, float value)
	{
		return false;
	}

	private static float GetFloat(string name)
	{
		return 0f;
	}

	public static float GetFloat(string name, float defaultValue)
	{
		return 0f;
	}

	public static bool SetString(string name, string value)
	{
		return false;
	}

	private static string GetString(string name)
	{
		return null;
	}

	public static string GetString(string name, string defaultValue)
	{
		return null;
	}

	public static bool SetVector2(string key, Vector2 vector)
	{
		return false;
	}

	private static Vector2 GetVector2(string key)
	{
		return default(Vector2);
	}

	public static Vector2 GetVector2(string key, Vector2 defaultValue)
	{
		return default(Vector2);
	}

	public static bool SetVector3(string key, Vector3 vector)
	{
		return false;
	}

	public static Vector3 GetVector3(string key)
	{
		return default(Vector3);
	}

	public static Vector3 GetVector3(string key, Vector3 defaultValue)
	{
		return default(Vector3);
	}

	public static bool SetQuaternion(string key, Quaternion vector)
	{
		return false;
	}

	public static Quaternion GetQuaternion(string key)
	{
		return default(Quaternion);
	}

	public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
	{
		return default(Quaternion);
	}

	public static bool SetColor(string key, Color color)
	{
		return false;
	}

	public static Color GetColor(string key)
	{
		return default(Color);
	}

	public static Color GetColor(string key, Color defaultValue)
	{
		return default(Color);
	}

	public static bool SetBoolArray(string key, bool[] boolArray)
	{
		return false;
	}

	public static bool[] GetBoolArray(string key)
	{
		return null;
	}

	public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
	{
		return null;
	}

	public static bool SetStringArray(string key, string[] stringArray)
	{
		return false;
	}

	public static string[] GetStringArray(string key)
	{
		return null;
	}

	public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
	{
		return null;
	}

	public static bool SetIntArray(string key, int[] intArray)
	{
		return false;
	}

	public static bool SetFloatArray(string key, float[] floatArray)
	{
		return false;
	}

	public static bool SetVector2Array(string key, Vector2[] vector2Array)
	{
		return false;
	}

	public static bool SetVector3Array(string key, Vector3[] vector3Array)
	{
		return false;
	}

	public static bool SetQuaternionArray(string key, Quaternion[] quaternionArray)
	{
		return false;
	}

	public static bool SetColorArray(string key, Color[] colorArray)
	{
		return false;
	}

	private static bool SetValue<T>(string key, T array, ArrayType arrayType, int vectorNumber, Action<T, byte[], int> convert) where T : IList
	{
		return false;
	}

	private static void ConvertFromInt(int[] array, byte[] bytes, int i)
	{
	}

	private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
	{
	}

	private static void ConvertFromVector2(Vector2[] array, byte[] bytes, int i)
	{
	}

	private static void ConvertFromVector3(Vector3[] array, byte[] bytes, int i)
	{
	}

	private static void ConvertFromQuaternion(Quaternion[] array, byte[] bytes, int i)
	{
	}

	private static void ConvertFromColor(Color[] array, byte[] bytes, int i)
	{
	}

	public static int[] GetIntArray(string key)
	{
		return null;
	}

	public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
	{
		return null;
	}

	public static float[] GetFloatArray(string key)
	{
		return null;
	}

	public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
	{
		return null;
	}

	public static Vector2[] GetVector2Array(string key)
	{
		return null;
	}

	public static Vector2[] GetVector2Array(string key, Vector2 defaultValue, int defaultSize)
	{
		return null;
	}

	public static Vector3[] GetVector3Array(string key)
	{
		return null;
	}

	public static Vector3[] GetVector3Array(string key, Vector3 defaultValue, int defaultSize)
	{
		return null;
	}

	public static Quaternion[] GetQuaternionArray(string key)
	{
		return null;
	}

	public static Quaternion[] GetQuaternionArray(string key, Quaternion defaultValue, int defaultSize)
	{
		return null;
	}

	public static Color[] GetColorArray(string key)
	{
		return null;
	}

	public static Color[] GetColorArray(string key, Color defaultValue, int defaultSize)
	{
		return null;
	}

	private static void GetValue<T>(string key, T list, ArrayType arrayType, int vectorNumber, Action<T, byte[]> convert) where T : IList
	{
	}

	private static void ConvertToInt(List<int> list, byte[] bytes)
	{
	}

	private static void ConvertToFloat(List<float> list, byte[] bytes)
	{
	}

	private static void ConvertToVector2(List<Vector2> list, byte[] bytes)
	{
	}

	private static void ConvertToVector3(List<Vector3> list, byte[] bytes)
	{
	}

	private static void ConvertToQuaternion(List<Quaternion> list, byte[] bytes)
	{
	}

	private static void ConvertToColor(List<Color> list, byte[] bytes)
	{
	}

	public static void ShowArrayType(string key)
	{
	}

	private static void Initialize()
	{
	}

	private static bool SaveBytes(string key, byte[] bytes)
	{
		return false;
	}

	private static void ConvertFloatToBytes(float f, byte[] bytes)
	{
	}

	private static float ConvertBytesToFloat(byte[] bytes)
	{
		return 0f;
	}

	private static void ConvertInt32ToBytes(int i, byte[] bytes)
	{
	}

	private static int ConvertBytesToInt32(byte[] bytes)
	{
		return 0;
	}

	private static void ConvertTo4Bytes(byte[] bytes)
	{
	}

	private static void ConvertFrom4Bytes(byte[] bytes)
	{
	}
}
