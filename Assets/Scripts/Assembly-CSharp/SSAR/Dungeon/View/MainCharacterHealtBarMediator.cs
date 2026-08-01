using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class MainCharacterHealtBarMediator : Mediator
	{
		[Inject]
		public MainCharacterHealthBarView view { get; set; }

		[Inject]
		public OnSpawnMainCharacterSignal OnSpawnMainCharacterSignal { get; set; }

		[Inject]
		public OnSpawnPetOfEntitySignal OnSpawnPetOfEntitySignal { get; set; }

		[Inject]
		public UpdateArcaneFormRemainingDurationSignal UpdateArcaneFormRemainingDurationSignal { get; set; }

		[Inject]
		public BackToNormalFormSignal BackToNormalFormSignal { get; set; }

		[Inject]
		public ChangeToArcaneFormSignal ChangeToArcaneFormSignal { get; set; }

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
