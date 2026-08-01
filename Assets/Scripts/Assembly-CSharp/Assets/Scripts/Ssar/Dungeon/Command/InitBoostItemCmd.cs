using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitBoostItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private void HpPotion()
		{
		}

		private void InitButton()
		{
		}

		private void ExpTicket()
		{
		}

		private void SoulTicket()
		{
		}

		private void AutoTicket()
		{
		}
	}
}
