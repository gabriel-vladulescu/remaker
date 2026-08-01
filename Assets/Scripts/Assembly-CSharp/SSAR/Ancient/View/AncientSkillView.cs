using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Ssar.Ancient.Model;
using UnityEngine;

namespace Ssar.Ancient.View
{
	public class AncientSkillView : MonoBehaviour
	{
		public UILabel lbName;

		public UILabel lbDesc;

		public void Show(EquipmentSkillInfo equipmentSkillInfo, int exp, Rarity rarity)
		{
		}

		public void ShowMinMaxStat(EquipmentSkillInfo equipmentSkillInfo, Rarity rarity, EquipmentTier min, EquipmentTier max)
		{
		}

		public void Hide()
		{
		}

		internal void UpdateData(ChargedAncientSkill chargedAncientSkill, bool fullDesc = true)
		{
		}
	}
}
