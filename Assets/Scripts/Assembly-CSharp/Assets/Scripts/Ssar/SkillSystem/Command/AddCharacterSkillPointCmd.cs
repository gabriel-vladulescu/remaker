using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.SkillSystem.Command
{
	public class AddCharacterSkillPointCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int value { get; set; }

		[Inject]
		public OnAddCharacterSkillPointSuccessSignal OnAddCharacterSkillPointSuccessSignal { get; set; }

		[Inject]
		public RewardReason RewardReason { get; set; }

		public override void Execute()
		{
		}
	}
}
