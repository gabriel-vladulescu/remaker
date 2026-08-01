using Assets.Scripts.Ssar.Dungeon.GameModeLogic.CostumeTestLevel;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.CharacterTestLevel
{
	public class CharacterTestFinishSetupDungeonCmd : CosmeticTestFinishSetupDungeonCmd
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private void Finish()
		{
		}
	}
}
