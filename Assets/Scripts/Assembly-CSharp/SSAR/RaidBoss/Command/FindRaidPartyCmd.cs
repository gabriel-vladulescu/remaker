using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.RaidBoss.API;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class FindRaidPartyCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public FindPartyParameter Parameter { get; set; }

		[Inject]
		public ShowRaidFindPartyPopupSignal ShowRaidFindPartyPopupSignal { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void FindParty()
		{
		}

		private int GetPower(MainCharacterData characterData)
		{
			return 0;
		}

		private string GetUserId(MainCharacterData characterData)
		{
			return null;
		}

		private void HandleCompanionNotFound()
		{
		}

		private void FindAgain()
		{
		}

		private void StartAlone()
		{
		}

		private void LoadCompanion(FindPartyResult result)
		{
		}

		private void ShowError(StatusCode statusCode, string message)
		{
		}

		private void KickOut(StatusCode statusCode, string message)
		{
		}
	}
}
