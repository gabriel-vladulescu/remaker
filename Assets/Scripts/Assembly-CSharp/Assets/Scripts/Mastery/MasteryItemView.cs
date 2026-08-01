using System;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class MasteryItemView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_level;

		public UILabel lb_name;

		public UILabel lb_statType;

		public UILabel lb_statValue;

		public GameObject wg_selected;

		public GameObject wgInfo;

		public GameObject wgCommingSoon;

		public GameObject iconNotify;

		private MasteryInfo masteryInfo;

		private Action<MasteryInfo> onClickAction;

		private void Awake()
		{
		}

		private void Select(GameObject go)
		{
		}

		public void ListenOnClick(Action<MasteryInfo> onClick)
		{
		}

		public void Show(MasteryInfo masteryInfo, MainCharacterData mainCharacterData)
		{
		}

		private bool Notify()
		{
			return false;
		}

		public void Hide()
		{
		}
	}
}
