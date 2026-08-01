using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.CharacterTestLevel
{
	public class CharacterTestModeBattleInterfaceLogic : IBattleInterfaceLogic, IDungeonInterfaceLogic
	{
		private AdventureWinButtonContainer buttonContainer;

		public string GetDungeonName()
		{
			return null;
		}

		public string GetStageDesc()
		{
			return null;
		}

		public void Instantiate()
		{
		}

		public void InstantiateButtonInWinPopup(GameObject parent)
		{
		}

		public void SetActiveButtonInWinPopup(bool active)
		{
		}

		public bool IsEnableWatchAdsToDoubleReward()
		{
			return false;
		}

		public void DungeonPausePopupExit()
		{
		}

		public void DungeonLosePopupClickExit()
		{
		}

		private void Back()
		{
		}

		public bool EnableStartWarning()
		{
			return false;
		}

		public string StartWarningMainText()
		{
			return null;
		}

		public string StartWarningSubText()
		{
			return null;
		}

		public bool WarningWhenClickExitInPopupPause()
		{
			return false;
		}
	}
}
