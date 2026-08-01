using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class CharacterStatDetailMediator : Mediator
	{
		[Inject]
		public CharacterStatDetail view { get; set; }

		[Inject]
		public ShowCharacterStatDetailSignal ShowCharacterStatDetailSignal { get; set; }

		[Inject]
		public HideCharacterStatDetailSignal HideCharacterStatDetailSignal { get; set; }

		[Inject]
		public OnEquipEquipmentSuccessSignal OnEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnAutoEquipEquipmentSuccessSignal OnAutoEquipEquipmentSuccessSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateData(IItem equipmentCollectData)
		{
		}

		private void CheckShow()
		{
		}
	}
}
