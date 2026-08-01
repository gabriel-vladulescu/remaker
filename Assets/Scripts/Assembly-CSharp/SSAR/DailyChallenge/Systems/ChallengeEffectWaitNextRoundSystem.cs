using Artemis.System;
using Ssar.DailyChallenge.View;

namespace Ssar.DailyChallenge.Systems
{
	public class ChallengeEffectWaitNextRoundSystem : EntitySystemWithTime
	{
		private ChallengeEffectWaitNextRoundView view;

		private bool enabled;

		private bool activated;

		private float duration;

		protected override void Process(float deltaTime)
		{
		}

		private void InitEffect()
		{
		}

		public void SetEnable(bool enabled)
		{
		}

		private void SetActivate(bool value)
		{
		}

		private void OnEnterStage(int stageOrder)
		{
		}

		private void OnClearStage(int stageOrder)
		{
		}

		private void OnWin()
		{
		}
	}
}
