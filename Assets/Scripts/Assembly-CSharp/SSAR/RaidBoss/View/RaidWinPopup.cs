using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.Dungeon.View;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidWinPopup : BasePopup
	{
		public DungeonWinRewardContainer DungeonWinRewardContainer;

		public RaidWinRankView RaidWinRankView;

		public GameObject btn_lobby;

		public GameObject btn_skill;

		public GameObject btn_inventory;

		public GameObject btn_mastery;

		public GameObject rightBottomButtonContainer;

		public UILabel lb_battleTime;

		public UILabel lb_stageName;

		public UILabel lb_rank;

		public UISprite sp_rankBg;

		private RaidWinParameter parameter;

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

		internal void Show(RaidWinParameter parameter)
		{
		}

		private void DisableAnotherView()
		{
		}

		private void SetActiveButton(bool active)
		{
		}

		private void CheckUnlockMastery(bool active)
		{
		}
	}
}
