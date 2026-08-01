using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnEnterDungeonStageCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		[Inject]
		public int stageOrder { get; set; }

		[Inject]
		public OnEnterDungeonStageSuccessSignal OnEnterDungeonStageSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
