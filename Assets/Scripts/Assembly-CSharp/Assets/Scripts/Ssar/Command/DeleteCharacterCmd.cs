using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class DeleteCharacterCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public OnDeleteCharacterSuccessSignal OnDeleteCharacterSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
