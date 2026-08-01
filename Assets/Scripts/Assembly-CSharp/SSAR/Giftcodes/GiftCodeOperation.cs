using System;
using System.Collections.Generic;
using Firebase.Firestore;

namespace Ssar.Giftcodes
{
	public class GiftCodeOperation
	{
		[FirestoreData]
		public class GiftCodeConfig
		{
			[FirestoreProperty]
			public string code { get; set; }

			[FirestoreProperty]
			public long expireTimeInSeconds { get; set; }

			[FirestoreProperty]
			public int group { get; set; }

			[FirestoreProperty]
			public int usageCount { get; set; }

			[FirestoreProperty]
			public List<GiftcodeReward> rewards { get; set; }
		}

		[FirestoreData]
		public class GiftcodeReward
		{
			[FirestoreProperty]
			public int itemId { get; set; }

			[FirestoreProperty]
			public string itemType { get; set; }

			[FirestoreProperty]
			public int quantity { get; set; }
		}

		[FirestoreData]
		public class GiftCodeUsageKey
		{
			[FirestoreProperty]
			public int count { get; set; }
		}

		private const string GIFT_CODE_CONFIG_SEGMENT = "giftCodeConfig";

		private const string GIFT_CODE_USAGE_SEGMENT = "giftCodeUsage";

		private const string GIFT_CODE_USER_SEGMENT = "giftCodeUser";

		private const string GIFT_CODE_USER_GROUP_SEGMENT = "giftCodeUserGroup";

		private FirebaseFirestore instance;

		private bool isGiftCodeUsageFailureNotified;

		private int counter;

		private bool isGiftCodeNotDepleted;

		private long newUsageCount;

		private bool isGiftCodeNotUsed;

		private bool isGiftCodeNotSameGroup;

		private float start;

		public void Import(GiftCodeFeed giftCodeFeed, Action<bool, string, string> result)
		{
		}

		public void Use(string userId, string code, Action<bool, string, List<GiftcodeReward>, string> result)
		{
		}

		private void OnGiftCodeUsageFailure(string code, List<GiftcodeReward> rewards, string error, Action<bool, string, List<GiftcodeReward>, string> result)
		{
		}

		private void OnGiftCodeNotDepleted(string userId, string code, long newUsageCount, long group, GiftCodeConfig giftCodeConfig, Action<bool, string, List<GiftcodeReward>, string> result)
		{
		}

		private void OnGiftCodeNotUsed(string userId, string code, long group, GiftCodeConfig giftCodeConfig, Action<bool, string, List<GiftcodeReward>, string> result)
		{
		}

		private void OnGiftCodeNotSameGroup(string userId, string code, long group, GiftCodeConfig giftCodeConfig, Action<bool, string, List<GiftcodeReward>, string> result)
		{
		}

		private void OnProcedure(string userId, string code, long group, GiftCodeConfig giftCodeConfig, Action<bool, string, List<GiftcodeReward>, string> result)
		{
		}

		private void CheckIfUserAlreadyUseGiftCodeOfSameGroup(string userId, string code, long group, Action<bool, string> result)
		{
		}

		private void CheckIfGiftCodeUsageDepleted(string code, long usageCountConfig, Action<bool, long, string> result)
		{
		}

		private void CheckIfUserAlreadyUseGiftCode(string userId, string code, Action<bool, string> result)
		{
		}

		private void SetValueOfGiftCodeUsage(string userId, string code, long newUsageCount, long group, Action<bool, string> result)
		{
		}

		private bool ShouldApplyGroupLogic(long group)
		{
			return false;
		}
	}
}
