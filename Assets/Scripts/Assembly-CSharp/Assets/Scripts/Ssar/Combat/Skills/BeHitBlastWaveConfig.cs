using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BeHitBlastWaveConfig : WeaponPassiveSkillConfig
	{
		public int knockbackLevel;

		public float knockbackDashDistance;

		public float knockbackDashDuration;

		public Vector2 size;

		public Vector2 offset;

		public string sfxPath;

		public bool drawGizmos;
	}
}
