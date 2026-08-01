using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.Dungeon.Model;
using strange.extensions.command.impl;

namespace SSAR.BattleSystem.System.AISystem
{
	public class LoadTestAISceneCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public TestAIInMode mode { get; set; }

		[Inject]
		public ScenarioDifficulty difficulty { get; set; }

		[Inject]
		public CharacterCode CharacterCode { get; set; }

		public override void Execute()
		{
		}
	}
}
