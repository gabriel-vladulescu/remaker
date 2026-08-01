using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	[Serializable]
	public class EffectConfig
	{
		public int frame;

		public string vfxPrefabPath;

		public Vector3 vfxOffset;

		public bool playOnGround;

		public bool deathFacingBackwardAttacker;
	}
}
