using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Social.Command
{
	public class SendJoinFacebookCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ItemInfo reward { get; set; }

		public override void Execute()
		{
		}
	}
}
