using Assets.Scripts.Ssar.Shop.Model;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ClaimSubscriptionPackageRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int day { get; set; }

		[Inject]
		public ISubscribeBoughtInfo SubscribeBoughtInfo { get; set; }

		public override void Execute()
		{
		}

		private void Instantly(NewSubscribePackageBoughtData boughtData, SubscribePackageRewardInfo subscribePackageRewardInfo)
		{
		}

		private void Daily(NewSubscribePackageBoughtData boughtData, SubscribePackageRewardInfo subscribePackageRewardInfo)
		{
		}
	}
}
