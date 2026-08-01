using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.Equipment.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnUsedAncientSkillCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public OnUsedAncientSkillParams Params { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private EquipmentCollectData GetUsedAncient(MainCharacterData mainCharacterData)
		{
			return null;
		}
	}
}
