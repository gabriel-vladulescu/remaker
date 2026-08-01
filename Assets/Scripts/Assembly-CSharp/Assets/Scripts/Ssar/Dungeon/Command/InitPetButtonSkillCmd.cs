using Artemis;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.View;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitPetButtonSkillCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private bool IsPet(Entity entity)
		{
			return false;
		}

		private PetButtonSkillView InitButton()
		{
			return null;
		}

		private void DisableAISkill(Entity entity)
		{
		}
	}
}
