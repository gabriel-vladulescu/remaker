using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Social.Command
{
	public class SendInviteFacebookCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public FacebookInviteRewardInfo RewardInfo { get; set; }

		[Inject]
		public string[] id { get; set; }

		public override void Execute()
		{
		}
	}
}
