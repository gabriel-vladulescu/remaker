using SSAR.Equipment.View;
using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class MasteryInventoryOverlay : IOverlay
	{
		private GameObject wgContainer;

		private Rune rune;

		public MasteryInventoryOverlay(Rune rune, GameObject wgContainer)
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
