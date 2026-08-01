using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.View;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class AdventureBattleInterfaceLogic : IBattleInterfaceLogic, IDungeonInterfaceLogic
	{
		private global::Scripts.Config.Dungeon dungeonInfo;

		private AdventureWinButtonContainer buttonContainer;

		public AdventureBattleInterfaceLogic(global::Scripts.Config.Dungeon dungeonInfo)
		{
		}

		public void Instantiate()
		{
		}

		public string GetDungeonName()
		{
			return null;
		}

		public string GetStageDesc()
		{
			return null;
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
