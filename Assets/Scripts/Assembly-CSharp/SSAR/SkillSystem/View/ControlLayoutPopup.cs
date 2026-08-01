using SSAR.SkillSystem.Model;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ControlLayoutPopup : BasePopup
	{
		public GameObject btn_close;

		public ControllerLayoutView controllerLayoutView;

		public GameObject btnSwap;

		public GameObject btnChange;

		private GameObject prefabSkill;

		private GameObject prefabAncient;

		private ControllerLayout currentLayout;

		private ControllerStyle currentStyle;

		private ControllerForm currentForm;

		protected override void Awake()
		{
		}

		private void Change(GameObject go)
		{
		}

		private void Swap(GameObject go)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		internal void Show()
		{
		}

		private ControllerLayout GetLayout(int id)
		{
			return null;
		}

		private ControllerLayout GetLayouts(ControllerForm form, ControllerStyle style)
		{
			return null;
		}

		private void LoadController(ControllerForm form, ControllerStyle style)
		{
		}

		private void ChangeControllerForm()
		{
		}

		private void SwapControlStyle()
		{
		}
	}
}
