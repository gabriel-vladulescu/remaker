using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Signal;
using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class UserButtonInputLayoutMediator : Mediator
	{
		[Inject]
		public UserButtonInputLayout view { get; set; }

		[Inject]
		public OnSpawnMainCharacterSignal OnSpawnMainCharacterSignal { get; set; }

		// Simplified: only the main-character spawn hookup is wired here. The
		// full game also injects signals for win/lose popups, joystick
		// show/hide, button visibility, form changes and controller layout
		// changes; StrangeIoC's Injector throws for any [Inject] property
		// with no binding (rather than injecting null), and none of those
		// signals are bound via commandBinder in this simplified
		// DungeonContext, so they're removed here rather than left to fail.
		public override void OnRegister()
		{
			view.Init();
			OnSpawnMainCharacterSignal.AddListener(view.OnSpawnMainCharacter);
		}

		public override void OnRemove()
		{
			OnSpawnMainCharacterSignal.RemoveListener(view.OnSpawnMainCharacter);
		}

		private void OnDestroy()
		{
		}

		private void Lose(DungeonLoseReason lose)
		{
		}
	}
}
