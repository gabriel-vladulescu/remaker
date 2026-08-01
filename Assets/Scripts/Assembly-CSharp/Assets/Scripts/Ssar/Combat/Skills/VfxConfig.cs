using System;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class VfxConfig
	{
		public bool ignoreCasterDirection;

		public string coordinateOrigin;

		public Vector2 offset;

		public CoordinateOrigin CoordinateOriginValue()
		{
			return default(CoordinateOrigin);
		}
	}
}
