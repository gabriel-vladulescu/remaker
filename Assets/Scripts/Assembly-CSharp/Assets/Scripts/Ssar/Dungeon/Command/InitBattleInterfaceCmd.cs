using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitBattleInterfaceCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}
	}
}
