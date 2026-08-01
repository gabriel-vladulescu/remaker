using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class ViewArenaUserInfoCmd : Command
	{
		[Inject]
		public string userId { get; set; }

		[Inject]
		public ShowUserInfoPopupSignal ShowUserInfoPopupSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
