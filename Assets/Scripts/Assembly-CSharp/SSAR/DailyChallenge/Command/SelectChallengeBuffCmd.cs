using Artemis;
using Scripts.Config;
using Ssar.DailyChallenge.Model;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class SelectChallengeBuffCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public SelectChallengeBuffParameters Parameters { get; set; }

		[Inject]
		public OnSelectChallengeBuffCompletedSignal CompletedSignal { get; set; }

		public override void Execute()
		{
		}

		private void ApplyBuff(DailyChallengeConfig.Buff buff)
		{
		}

		private void ShowBuffIcon(Entity main, DailyChallengeConfig.Buff buff)
		{
		}
	}
}
