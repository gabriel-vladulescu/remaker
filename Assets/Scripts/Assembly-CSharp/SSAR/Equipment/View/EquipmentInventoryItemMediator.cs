using Assets.Scripts.Ssar.Signal;
using SSAR.Equipment.Model;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class EquipmentInventoryItemMediator : Mediator
	{
		[Inject]
		public EquipmentInventoryItemView view { get; set; }

		[Inject]
		public OnEnhanceEquipmentSuccessSignal OnEnhanceEquipmentSuccessSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateStatDiff(EquipmentCollectData equipmentCollectData)
		{
		}
	}
}
