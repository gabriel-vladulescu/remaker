using System.Collections.Generic;

namespace Ssar.Giftcodes
{
	public class GiftCode
	{
		public string code;

		public int group;

		public int usageCount;

		public long expireTimeInSeconds;

		public List<GiftCodeOperation.GiftcodeReward> rewards;
	}
}
