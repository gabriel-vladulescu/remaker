using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftableEquipmentDetailView : MonoBehaviour
	{
		public UILabel lb_title;

		public UILabel lb_value;

		public UIWidget leftContainer;

		public UIWidget rightContainer;

		private const int leftContainerOffset = 70;

		private const int rightContainerOffset = -80;

		public void Init(UIWidget anchor)
		{
		}

		public void Show(string title, string[] values, string ext = "")
		{
		}

		public void Hide()
		{
		}
	}
}
