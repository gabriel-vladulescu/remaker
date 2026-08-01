using Assets.Scripts.Ssar.Command;
using UnityEngine;

namespace Ssar.WorldMap.View
{
	public class DeathPenaltyWarningPopup : BasePopup
	{
		[SerializeField]
		private UILabel lbHeadline;

		[SerializeField]
		private UILabel lbContent;

		[SerializeField]
		private DeathPenaltyNodeView nodeView;

		[SerializeField]
		private GameObject btnOk;

		[SerializeField]
		private GameObject btnConfirm;

		[SerializeField]
		private GameObject btnCancel;

		private DeathPenaltyWarningParameter parameter;

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

		internal void Show(DeathPenaltyWarningParameter parameter)
		{
		}

		private string GetHeadline()
		{
			return null;
		}

		private string GetContent()
		{
			return null;
		}

		private bool IsConfirmWarning()
		{
			return false;
		}
	}
}
