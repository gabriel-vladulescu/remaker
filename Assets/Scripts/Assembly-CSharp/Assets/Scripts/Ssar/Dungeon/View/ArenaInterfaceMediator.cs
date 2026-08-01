using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaInterfaceMediator : Mediator
	{
		[Inject]
		public ArenaInterfaceView view { get; set; }

		[Inject]
		public OnSpawnLeftArenaCharacterSignal OnSpawnLeftArenaCharacterSignal { get; set; }

		[Inject]
		public OnSpawnRightArenaCharacterSignal OnSpawnRightArenaCharacterSignal { get; set; }

		[Inject]
		public OnSpawnPetOfEntitySignal OnSpawnPetOfEntitySignal { get; set; }

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
