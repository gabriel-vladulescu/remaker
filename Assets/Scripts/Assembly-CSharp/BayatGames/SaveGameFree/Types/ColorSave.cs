using System;
using UnityEngine;

namespace BayatGames.SaveGameFree.Types
{
	[Serializable]
	public struct ColorSave
	{
		public float r;

		public float g;

		public float b;

		public float a;

		public ColorSave(Color color)
		{
			r = 0f;
			g = 0f;
			b = 0f;
			a = 0f;
		}

		public static implicit operator ColorSave(Color color)
		{
			return default(ColorSave);
		}

		public static implicit operator Color(ColorSave color)
		{
			return default(Color);
		}
	}
}
