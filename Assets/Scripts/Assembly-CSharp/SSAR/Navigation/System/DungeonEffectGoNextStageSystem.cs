using Artemis.System;
using SSAR.Navigation.View;

namespace SSAR.Navigation.System
{
	public class DungeonEffectGoNextStageSystem : EntitySystemWithTime
	{
		private DungeonEffectGoNextStageView view;

		private bool enabled;

		private void OnEnterStage(int stageOrder)
		{
		}

		private void OnClearStage(int stageOrder)
		{
		}

		private void OnWin()
		{
		}

		private void InitEffect()
		{
		}

		protected override void Process(float deltaTime)
		{
		}

		public void SetEnable(bool enabled)
		{
		}
	}
}
