using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Ancient.View
{
	public class EnhanceAncientSuccessPopup : BasePopup
	{
		public GameObject detailContainer;

		public GameObject btnOk;

		public GameObject mask;

		public UIPanel detailPane;

		public TweenScale light;

		public TweenScale info;

		private EquipmentInfoContainer equipmentInfoContainer;

		private UIWidget[] widgets;

		private UIPanel panel;

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

		private void Init()
		{
		}

		private void Close(GameObject o)
		{
		}

		private void Close()
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData)
		{
		}
	}
}
