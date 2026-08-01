using Assets.Scripts.Ssar.Command;
using UnityEngine;

namespace Ssar.WorldMap.View
{
	public class DungeonDeathPenaltyPopup : BasePopup
	{
		[SerializeField]
		private UILabel lbTitle;

		[SerializeField]
		private UILabel lbHeadline;

		[SerializeField]
		private UILabel lbContent;

		[SerializeField]
		private DeathPenaltyNodeView nodeView;

		[SerializeField]
		private GameObject btnOk;

		private DungeonDeathPenaltyPopupParameter parameter;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Confirm(GameObject go)
		{
		}

		internal void Show(DungeonDeathPenaltyPopupParameter parameter)
		{
		}

		private bool IsFirstDeath()
		{
			return false;
		}

		private string GetTitle()
		{
			return null;
		}

		private string GetContent()
		{
			return null;
		}

		private string GetHeadline()
		{
			return null;
		}

		private void ShowLostSouls()
		{
		}
	}
}
