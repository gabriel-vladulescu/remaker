using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.Reforge.Enum;
using Ssar.Rune;
using strange.extensions.command.impl;

namespace Ssar.Reforge.Command
{
	public class ReforgeConfirmTakeNewEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ReforgeConfirmTakeNewEquipmentParameter Parameter { get; set; }

		[Inject]
		public OnReforgeResultConfirmedSignal ConfirmedSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendReforgeTakeMetric(ReforgeType runeType, EquipmentType equipmentType, Rarity rarity)
		{
		}
	}
}
