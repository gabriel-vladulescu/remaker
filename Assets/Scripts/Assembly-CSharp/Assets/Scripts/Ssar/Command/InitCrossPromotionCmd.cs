using Assets.Scripts.Ssar.Signal;
using crosspromotion;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class InitCrossPromotionCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CrossPromotionMetricSignal CrossPromotionMetricSignal { get; set; }

		public override void Execute()
		{
		}

		private void OnError(Error error, string message)
		{
		}

		private void ClaimReward(string type, int value)
		{
		}

		private void Open()
		{
		}

		private void Close()
		{
		}

		private void Action(Interact interact, CrossPromotionItemConfig appId)
		{
		}
	}
}
