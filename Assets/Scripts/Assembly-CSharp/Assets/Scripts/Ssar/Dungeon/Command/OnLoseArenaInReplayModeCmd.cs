using Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnLoseArenaInReplayModeCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ArenaModeParameter ArenaModeParameter { get; set; }

		[Inject]
		public ShowArenaLosePopupSignal ShowArenaLosePopupSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
