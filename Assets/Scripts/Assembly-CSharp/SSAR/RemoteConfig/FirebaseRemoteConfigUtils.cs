using System.Collections.Generic;
using SSAR.View;

namespace Ssar.RemoteConfig
{
	public static class FirebaseRemoteConfigUtils
	{
		public const string GIFTCODE_ENABLE = "giftcode_enable";

		public const string DEATH_PENALTY_ENABLED = "death_penalty_enabled";

		public const string DEATH_PENALTY_MODE = "death_penalty_mode";

		public const string FREE_SUBSCRIBE_ENABLED = "free_subscribe_enabled";

		public const string MAIN_SCENE_LIMIT_PACK = "main_scene_limit_pack";

		public const string MAIN_SCENE_HOT_DEAL = "main_scene_hot_deal";

		public const string MAIN_SCENE_DEAL_ORDER = "main_scene_deal_order";

		public const string RESET_IAP_DAY_OF_WEEK = "reset_iap_dow";

		public const string RESET_IAP_ENABLED = "reset_iap_enabled";

		public const string RATING_SHOW_AT_DUNGEONS = "rating_dungeons";

		public const string COMPRESS_SAVE_DATA = "zip_save";

		public const string COMPRESS_ARENA_SAVE_DATA = "zip_arena";

		public const string DECOMPRESS_LOAD_DATA = "unzip_load";

		public const string COMPRESS_LIBRARY = "lib_zip";

		public const string COMPRESS_CHUCK_SIZE = "zip_chuck_size";

		public const string REMOVE_OVERLOAD_TRANSITION_DATA = "min_purchase";

		public const string DEFAULT_CONTROL_LAYOUT = "default_control_layout";

		public const string DAILY_LOGIN_REWARD_CLAIM_MODE = "daily_claim_mode";

		public const string ENABLE_AUTO_NOTIFY_BUNDLE = "auto_notify_bundle";

		public const string REPROCESS_UI_TEXT = "reprocess_ui_text";

		public const string UNLOCK_CRAFT_CONDITION = "craft_unlock";

		public const string UNLOCK_CARD_SHOP_CONDITION = "card_shop_unlock";

		public const string UNLOCK_VENDOR_CONDITION = "vendor_unlock";

		public const string UNLOCK_GALLERY_CONDITION = "gallery_unlock";

		public const string UNLOCK_PET_CONDITION = "pet_unlock";

		public const string UNLOCK_RUNE_CONDITION = "rune_unlock";

		public const string UNLOCK_ACHIVEMENT_CONDITION = "achivement_unlock";

		public const string UNLOCK_STORE_CONDITION = "store_unlock";

		public const string UNLOCK_TOWER_CONDITION = "tower_unlock";

		public const string UNLOCK_ARENA_CONDITION = "arena_unlock";

		public const string UNLOCK_RAID_CONDITION = "raid_unlock";

		public const string UNLOCK_DAILY_CHALLENGE_CONDITION = "dc_unlock";

		public const string UNLOCK_FLASH_SALE_CONDITION = "flashsale_unlock";

		public const string CHALLENGE_MAP_LOCK_TYPE = "challenge_map_lock_type";

		public const string DAILY_CHALLENG_MAX_ENTRY_PER_DAY = "dc_max_entry";

		public const string DAILY_CHALLENGE_TIME = "dc_time";

		public const string MARKET_METRIC_PARAMETERS = "mmp";

		public const string DEMON_INVASION_VERSION_ID = "di_version_id";

		public const string DEMON_INVASION_EVENT_ID = "di_event_id";

		public const string DEMON_INVASION_EVENT_TIME = "di_event_time";

		public const string DEMON_INVASION_CHALLENGE_TIME = "di_challenge_time";

		public const string SHOP_BLACK_FRIDAY_TIME = "shop_black_friday_time";

		public const string EVENT_QUINN_REQUEST_TIME = "event_quinn_request_time";

		public const string EVENT_MORE_THAN_CRYSTAL_TIME = "event_more_than_crystal_time";

		public const string EVENT_MORE_THAN_SOUL_TIME = "event_more_than_soul_time";

		public const string XMAS_ONLINE_TIME = "xmas_online_time";

		public const string XMAS_WAR_TIME = "xmas_war_time";

		public const string RATING_POPUP = "rating_popup";

		public const string AF_NET_IAP_ANDROID = "af_net_IAP_android";

		public const string AF_NET_IAP_IOS = "af_net_IAP_ios";

		public const string HIEN_QC = "hien_qc";

		public const string BAD_RATING_TO_STORE = "bad_rating_to_store";

		private static Dictionary<ChallengeMapButton.Mode, ChallengeMapButton.LockType> cacheLockTypes;

		public static bool GetBool(string key)
		{
			return false;
		}

		public static float GetFloat(string key)
		{
			return 0f;
		}

		public static int GetInt(string key)
		{
			return 0;
		}

		public static string GetString(string key)
		{
			return null;
		}

		public static bool IsGiftCodeEnabled()
		{
			return false;
		}

		public static bool IsDeathPenaltyEnabled(ScenarioDifficulty difficulty)
		{
			return false;
		}

		public static bool IsBadRatingToStoreEnable()
		{
			return false;
		}

		public static ChallengeMapButton.LockType GetChallengeMapLockType(ChallengeMapButton.Mode mode)
		{
			return default(ChallengeMapButton.LockType);
		}

		public static string[] GetDailyChallengeTime()
		{
			return null;
		}

		public static string GetDemonInvasionEventId()
		{
			return null;
		}

		public static string[] GetDemonInvasionChallengeTime()
		{
			return null;
		}

		public static string[] GetDemonInvasionEventTime()
		{
			return null;
		}

		public static string[] GetShopBlackFridayTime()
		{
			return null;
		}

		public static string[] GetXmasOnlineEventTime()
		{
			return null;
		}

		public static string[] GetXmasWarEventTime()
		{
			return null;
		}

		public static string[] GetEventTime(string eventKey)
		{
			return null;
		}
	}
}
