using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentSubstatView : MonoBehaviour
	{
		public class ComparerResult
		{
			public string arrowName;

			public string colorBBcode;

			public ComparerResult(float comparerDiff)
			{
			}
		}

		private const int leftContainerOffset = 70;

		private const int rightContainerOffset = -80;

		private const int titleOffsetWithDot = 20;

		private const int valueOffsetWithArrow = -20;

		public UILabel lb_value;

		public UILabel lb_title;

		public UISprite sp_arrow;

		public UIWidget leftContainer;

		public UIWidget rightContainer;

		public void Init(UIWidget anchor)
		{
		}

		public void Show(ShowSubStatParameter parameter)
		{
		}

		public void Hide()
		{
		}
	}
}
