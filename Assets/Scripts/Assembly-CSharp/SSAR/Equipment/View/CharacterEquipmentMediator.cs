using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class CharacterEquipmentMediator : Mediator
	{
		[Inject]
		public CharacterEquipmentView view { get; set; }

		[Inject]
		public OnEquipEquipmentSuccessSignal OnEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnUnequipEquipmentSuccessSignal OnUnequipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnAutoEquipEquipmentSuccessSignal OnAutoEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public ShowCharacterStatDetailSignal ShowCharacterStatDetailSignal { get; set; }

		[Inject]
		public HideCharacterStatDetailSignal HideCharacterStatDetailSignal { get; set; }

		[Inject]
		public OnEnableEquipmentVisualSignal OnEnableEquipmentVisualSignal { get; set; }

		[Inject]
		public OnDisableEquipmentVisualSignal OnDisableEquipmentVisualSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
