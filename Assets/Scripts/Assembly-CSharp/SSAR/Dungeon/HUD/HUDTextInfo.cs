using System;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	[Serializable]
	public class HUDTextInfo
	{
		public HUDTextType type;

		public HUDTextGroupType groupType;

		public Color color;

		public Color outlineColor;

		public Color gradientTop;

		public Color gradientBot;

		public int size;

		public int outlineSize;

		public HUDTextInfo()
		{
		}

		public HUDTextInfo(HUDTextType type)
		{
		}

		public HUDTextInfo(HUDTextInfo info)
		{
		}
	}
}
