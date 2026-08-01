using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class InitDailyChallengeDungeonSystemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		public override void Execute()
		{
		}
	}
}
