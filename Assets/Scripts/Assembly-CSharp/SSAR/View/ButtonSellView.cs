using System;
using UnityEngine;

namespace SSAR.View
{
	public class ButtonSellView : MonoBehaviour
	{
		public UILabel lb_title;

		public UILabel lb_value;

		public UITable table;

		private Action onC;

		private void Awake()
		{
		}

		public void ListenerOnClick(Action o)
		{
		}

		public void UpdateTitle(string text)
		{
		}

		public void UpdateValue(int value, string prefix)
		{
		}

		private void ClickObj(GameObject o)
		{
		}
	}
}
