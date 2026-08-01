using Artemis;
using Artemis.System;
using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.BattleSystem.System.Indicator.Component;
using Scripts.Config;

namespace Ssar.BattleSystem.Indicator.System
{
	public class DungeonIndicatorSystem : EntityProcessingSystemWithTime
	{
		private IBattleModeLogic battleModeLogic;

		private IDungeonInfo dungeonInfo;

		private int stageOrder;

		private Stage curStage;

		public DungeonIndicatorSystem(IBattleModeLogic battleModeLogic, Assets.Scripts.Ssar.Dungeon.Dungeon dungeon, bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}

		private bool IsValidTarget(MonsterIndicatorComponent indicator)
		{
			return false;
		}

		private void OnStageCycle(int stageOrder, Assets.Scripts.Ssar.Dungeon.Dungeon.StageCycle cycle)
		{
		}
	}
}
