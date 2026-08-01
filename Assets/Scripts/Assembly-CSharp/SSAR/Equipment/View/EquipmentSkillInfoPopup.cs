using SSAR.Entry.Model;
using SSAR.Equipment.Model;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentSkillInfoPopup : BasePopup
	{
		public GameObject container;

		public UILabel lb_name;

		public UILabel lb_desc;

		public UIWidget bg;

		public UILabel lb_lv;

		public GameObject mask;

		private HeroConfig heroConfig;

		private JsonEquipmentDropConfig jsonEquipmentDropConfig;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(EquipmentSkillInfo equipmentSkillInfo, GameObject objectClicked, Vector2 offset, int groupId)
		{
		}

		public void Show(ShowSkillInfoParameter showSkillInfoParameter)
		{
		}

		private void UpdateDesc(string text)
		{
		}

		private void UpdateSize()
		{
		}

		private void UpdatePosition(GameObject objectClicked, Vector3 offset)
		{
		}
	}
}
