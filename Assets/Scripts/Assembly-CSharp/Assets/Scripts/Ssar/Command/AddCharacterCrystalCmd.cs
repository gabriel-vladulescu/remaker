using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class AddCharacterCrystalCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int value { get; set; }

		[Inject]
		public string source { get; set; }

		[Inject]
		public RewardReason RewardReason { get; set; }

		public override void Execute()
		{
		}
	}
}
