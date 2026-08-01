using Assets.Scripts.Model;
using Scripts.Config;
using Scripts.Ssar.Pet;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class SellOneEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IItem EquipmentCollectData { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendSellEquipmentMetric(int price)
		{
		}

		private EquipmentConfig GetEquipmentConfig()
		{
			return null;
		}

		private void SendSellPetMetric(PetCollectData petCollectData)
		{
		}
	}
}
