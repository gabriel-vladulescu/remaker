using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using Ssar.RaidBoss.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class RaidBossBattleInterfaceLogic : IBattleInterfaceLogic, IDungeonInterfaceLogic
	{
		private RaidBossConfig.Room roomInfo;

		private RaidWinButtonContainer buttonContainer;

		public RaidBossBattleInterfaceLogic(RaidBossConfig.Room roomInfo)
		{
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

		public bool WarningWhenClickExitInPopupPause()
		{
			return false;
		}

		public string GetDungeonName()
		{
			return null;
		}

		public string GetStageDesc()
		{
			return null;
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
	}
}
