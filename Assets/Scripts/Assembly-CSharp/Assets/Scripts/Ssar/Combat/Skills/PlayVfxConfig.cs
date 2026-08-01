using System;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class PlayVfxConfig
	{
		[PreloadPool.PrefabPathMarker]
		public string prefabPath;

		public Vector2 offset;

		public bool playOnGround;
	}
}
