using UnityEngine;

namespace Ssar.SoulLink.View
{
	public class SoulLinkPopup : BasePopup
	{
		public GameObject btnClose;

		public UITable container;

		private SoulLinkCharacterView[] characterViews;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Init()
		{
		}

		internal void Show()
		{
		}
	}
}
