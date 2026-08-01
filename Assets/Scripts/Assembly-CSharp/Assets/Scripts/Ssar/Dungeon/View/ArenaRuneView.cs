using System;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaRuneView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_name;

		public UILabel lb_desc;

		public TweenScale TweenScale;

		public TweenScale TweenHide;

		public TweenAlpha tweenAlpha;

		public Action<ArenaRuneInfo> select;

		public ArenaRuneInfo runeInfo;

		private GameObject fx;

		private void Awake()
		{
		}

		public void Show(ArenaRuneInfo runeInfo, int playAtFrame, int duration)
		{
		}

		public void Hide()
		{
		}

		private float GetDuration(int frame)
		{
			return 0f;
		}
	}
}
