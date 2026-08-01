using System.Collections.Generic;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Signal;
using Scripts.Ssar.Pet;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class AwakenEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IItem EquipmentCollectData { get; set; }

		[Inject]
		public List<IItem> materials { get; set; }

		[Inject]
		public OnAwakenEquipmentSuccessSignal OnAwakenEquipmentSuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendAwakenPetMetric(PetCollectData petCollectData)
		{
		}

		private void UpdateExp()
		{
		}

		private void DeleteMaterial()
		{
		}
	}
}
