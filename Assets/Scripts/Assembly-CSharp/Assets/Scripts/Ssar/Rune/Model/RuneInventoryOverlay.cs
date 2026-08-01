using SSAR.Equipment.View;
using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.Model
{
	public class RuneInventoryOverlay : IOverlay
	{
		private GameObject wgSelect;

		private global::Ssar.Rune.Model.Rune rune;

		public RuneInventoryOverlay(global::Ssar.Rune.Model.Rune rune, GameObject wgSelect)
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
