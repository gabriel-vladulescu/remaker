using SSAR.Equipment.Model;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentSkillView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_lv;

		public UILabel lb_name;

		public GameObject btn_click;

		private EquipmentSkillInfo skillInfo;

		private HeroConfig heroConfig;

		private JsonEquipmentDropConfig jsonEquipmentDropConfig;

		private int groupId;

		private void Awake()
		{
		}

		public void Show(EquipmentSkillInfo equipmentSkillInfo, int groupId)
		{
		}

		private void ActiveSkillInfo(EquipmentSkillInfo equipmentSkillInfo, int groupId)
		{
		}

		private void PassiveSkillInfo(EquipmentSkillInfo equipmentSkillInfo, int groupId)
		{
		}

		public void Hide()
		{
		}
	}
}
