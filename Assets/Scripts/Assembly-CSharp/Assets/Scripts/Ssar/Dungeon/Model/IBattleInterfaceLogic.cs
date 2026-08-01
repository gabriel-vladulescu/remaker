using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public interface IBattleInterfaceLogic
	{
		void Instantiate();

		void InstantiateButtonInWinPopup(GameObject parent);

		void SetActiveButtonInWinPopup(bool active);

		bool IsEnableWatchAdsToDoubleReward();

		void DungeonPausePopupExit();

		void DungeonLosePopupClickExit();

		bool WarningWhenClickExitInPopupPause();
	}
}
