using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Rune.Model
{
	public class ReforgeRuneInventoryOverlay : IOverlay
	{
		private GameObject wgSelect;

		private Rune rune;

		public ReforgeRuneInventoryOverlay(Rune rune, GameObject wgSelect)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public bool IsEnable()
		{
			return false;
		}

		public int Priority()
		{
			return 0;
		}
	}
}
