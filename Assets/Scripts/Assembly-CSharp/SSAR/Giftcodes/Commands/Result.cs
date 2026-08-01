using System.Collections.Generic;

namespace Ssar.Giftcodes.Commands
{
	public class Result
	{
		private bool success;

		private string code;

		private List<GiftCodeOperation.GiftcodeReward> rewards;

		private string error;

		public bool Success => false;

		public string Code => null;

		public List<GiftCodeOperation.GiftcodeReward> Rewards => null;

		public string Error => null;

		public Result(bool success, string code, List<GiftCodeOperation.GiftcodeReward> rewards, string error)
		{
		}
	}
}
