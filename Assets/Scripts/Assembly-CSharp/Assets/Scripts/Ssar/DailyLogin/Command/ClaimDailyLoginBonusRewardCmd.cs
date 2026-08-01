using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.DailyLogin.Command
{
	public class ClaimDailyLoginBonusRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int day { get; set; }

		[Inject]
		public OnClaimDailyLoginBonusRewardSuccessSignal OnClaimDailyLoginBonusRewardSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void AddReward()
		{
		}

		private DailyLoginGift GetGift(int day)
		{
			return null;
		}
	}
}
