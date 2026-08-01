using SSAR.Equipment.Enum;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class CharacterStatDetailRowView : MonoBehaviour
	{
		public UIWidget widget;

		public UILabel lb_title;

		public UILabel lb_value;

		private string bbcode;

		private StatType statType;

		private string bonusBBCode;

		public void Init(StatType statType, int width, bool hasColor = false)
		{
		}

		public void UpdateValue(float value, string ext = "")
		{
		}

		public void UpdateValueWithBonus(float value, float bonusValue, string ext = "")
		{
		}
	}
}
