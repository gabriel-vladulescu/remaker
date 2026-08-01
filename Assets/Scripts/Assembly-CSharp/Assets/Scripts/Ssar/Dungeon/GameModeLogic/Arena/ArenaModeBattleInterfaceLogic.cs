using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.BattleSystem.System.Arena.Api;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena
{
	public class ArenaModeBattleInterfaceLogic : IBattleInterfaceLogic
	{
		private string opponentId;

		private ArenaModeParameter parameter;

		public ArenaModeBattleInterfaceLogic(string opponentId, ArenaModeParameter parameter)
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

		private void Success(UpdateDuelResultData data)
		{
		}

		public void DungeonLosePopupClickExit()
		{
		}

		public bool WarningWhenClickExitInPopupPause()
		{
			return false;
		}
	}
}
