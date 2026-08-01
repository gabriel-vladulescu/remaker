using System.Collections.Generic;
using SSAR.Equipment.View;
using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class MasteryPopupInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_overlayText;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		private void Click(GameObject o)
		{
		}

		public Rune GetRune()
		{
			return null;
		}

		protected override List<IOverlay> Overlay()
		{
			return null;
		}
	}
}
