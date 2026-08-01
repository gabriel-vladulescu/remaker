using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.CharacterSelection.Command
{
	public class SelectCharacterCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public TapToPlaySignal TapToPlaySignal { get; set; }

		public override void Execute()
		{
		}
	}
}
