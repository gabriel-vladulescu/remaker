using SSAR.Equipment.Enum;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class AwakenStatRowView : MonoBehaviour
	{
		public UILabel lb_type;

		public UILabel lb_before;

		public UILabel lb_after;

		public UISprite sp_dot;

		public void Show(StatType type, float valueBefore, float valueAfter, bool isMain)
		{
		}

		public void Hide()
		{
		}
	}
}
