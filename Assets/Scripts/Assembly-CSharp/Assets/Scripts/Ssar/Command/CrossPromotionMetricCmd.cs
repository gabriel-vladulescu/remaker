using Assets.Scripts.Ssar.Entry;
using crosspromotion;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class CrossPromotionMetricCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CrossPromotionAction Action { get; set; }

		[Inject]
		public CrossPromotionItemConfig config { get; set; }

		public override void Execute()
		{
		}

		private void SendMetric()
		{
		}
	}
}
