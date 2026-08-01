using System;
using UnityEngine;

namespace BayatGames.SaveGameFree.Types
{
	[Serializable]
	public struct Color32Save
	{
		public byte r;

		public byte g;

		public byte b;

		public byte a;

		public Color32Save(Color32 color)
		{
			r = 0;
			g = 0;
			b = 0;
			a = 0;
		}

		public static implicit operator Color32Save(Color32 color)
		{
			return default(Color32Save);
		}

		public static implicit operator Color32(Color32Save color)
		{
			return default(Color32);
		}
	}
}
