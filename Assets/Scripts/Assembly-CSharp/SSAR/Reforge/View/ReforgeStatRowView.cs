using SSAR.Equipment.Enum;
using UnityEngine;

namespace Ssar.Reforge.View
{
	public class ReforgeStatRowView : MonoBehaviour
	{
		public UILabel lb_type;

		public UILabel lb_value;

		public UISprite sp_dot;

		public void Show(StatType type, float[] values, bool isOriginaValue, bool isMain = false)
		{
		}

		public void Show(string text, string[] values, string ext)
		{
		}

		public void Show(string text)
		{
		}

		public void Hide()
		{
		}
	}
}
