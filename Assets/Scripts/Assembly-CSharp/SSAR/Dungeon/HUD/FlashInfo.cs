using System;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	[Serializable]
	public class FlashInfo
	{
		public FlashType type;

		public AnimationCurve curve;

		public float duration;

		public Color color;

		public string colorKey;

		public string powerKey;
	}
}
