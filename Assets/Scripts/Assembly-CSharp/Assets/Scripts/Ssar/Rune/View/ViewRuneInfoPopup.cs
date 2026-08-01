using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class ViewRuneInfoPopup : BasePopup
	{
		public GameObject wgInfoContainer;

		private RuneInfoView runeInfoView;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(global::Ssar.Rune.Model.Rune rune)
		{
		}

		private void InitRuneInfo()
		{
		}
	}
}
