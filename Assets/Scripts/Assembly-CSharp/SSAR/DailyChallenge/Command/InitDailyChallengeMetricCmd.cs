using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class InitDailyChallengeMetricCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void OnEnterStage(int stageOrder)
		{
		}

		private void OnClearStage(int stageOrder)
		{
		}

		private BaseData GetBaseData()
		{
			return null;
		}

		private ScenarioDifficulty GetDifficulty()
		{
			return default(ScenarioDifficulty);
		}
	}
}
