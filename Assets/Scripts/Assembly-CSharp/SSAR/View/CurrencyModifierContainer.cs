using System;
using UnityEngine;

namespace SSAR.View
{
	public class CurrencyModifierContainer : MonoBehaviour
	{
		public UILabel lb_currentValue;

		public UIScrollBar scrollBar;

		public GameObject btn_plus;

		public GameObject btn_minus;

		private int currentValue;

		private int m_maxvalue;

		private Action<int> changeValue;

		private void Awake()
		{
		}

		public void ListenerOnChangeValue(Action<int> onChangeValue)
		{
		}

		public void Init(int startValue, int maxValue)
		{
		}

		private void ClickPlus(GameObject o)
		{
		}

		private void ClickMinus(GameObject o)
		{
		}

		private void OnChangeScrollBar()
		{
		}

		private int MaxValue()
		{
			return 0;
		}
	}
}
