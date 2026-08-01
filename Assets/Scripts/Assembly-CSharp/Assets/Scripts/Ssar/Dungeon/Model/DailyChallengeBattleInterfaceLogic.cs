using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using Ssar.DailyChallenge.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class DailyChallengeBattleInterfaceLogic : IBattleInterfaceLogic, IDungeonInterfaceLogic
	{
		private DailyChallengeConfig.Dungeon dungeon;

		private ChallengeWinButtonContainer buttonContainer;

		public DailyChallengeBattleInterfaceLogic(DailyChallengeConfig.Dungeon dungeon)
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
