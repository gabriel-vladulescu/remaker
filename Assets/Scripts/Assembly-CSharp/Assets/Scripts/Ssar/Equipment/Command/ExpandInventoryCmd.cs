using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ExpandInventoryCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int valueIncrease { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private InventoryExpandConfig Config()
		{
			return null;
		}
	}
}
