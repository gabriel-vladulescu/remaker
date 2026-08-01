using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.Dungeon.View;
using Ssar.DailyChallenge.Model;
using UnityEngine;

namespace Ssar.DailyChallenge.View
{
	public class ChallengeWinPopup : BasePopup
	{
		public DungeonWinRewardContainer DungeonWinRewardContainer;

		public GameObject btn_lobby;

		public GameObject btn_skill;

		public GameObject btn_inventory;

		public GameObject btn_mastery;

		public GameObject rightBottomButtonContainer;

		public UILabel lb_battleTime;

		public UILabel lb_rounds;

		public UILabel lb_stageName;

		public UILabel lb_title;

		private ChallengeEndParameters parameters;

		private bool isClickBtnLobby;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		private void BackLobby()
		{
		}

		private void OpenSkill(GameObject o)
		{
		}

		private void OpenInventory(GameObject o)
		{
		}

		private void OpenMastery(GameObject o)
		{
		}

		private IBattleModeLogic BattleModeLogic()
		{
			return null;
		}

		internal virtual void Show(ChallengeEndParameters parameters)
		{
		}

		private void SetActiveButton(bool active)
		{
		}

		private string GetRoundText(ChallengeEndParameters parameters)
		{
			return null;
		}

		private string GetStageText(ChallengeEndParameters parameters)
		{
			return null;
		}
	}
}
