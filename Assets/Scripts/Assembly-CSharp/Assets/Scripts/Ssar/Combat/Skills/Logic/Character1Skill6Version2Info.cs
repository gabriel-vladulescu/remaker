using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	[Serializable]
	public class Character1Skill6Version2Info
	{
		public List<WeaponVfxInfo2> weaponVfxInfos;

		public Vector2 centerOffset;

		public float radius;

		public int count;

		public float angle;

		public int intervalInFrames;

		public int appearFrame;

		public int scaleDurationInFrames;

		public Vector3 scaleFrom;

		public int standbyDurationInFrames;

		public int flyDurationInFrame;

		public Vector3 scaleTo;

		public float IntervalInSeconds()
		{
			return 0f;
		}

		public float AppearSeconds()
		{
			return 0f;
		}

		public float ScaleDurationInSeconds()
		{
			return 0f;
		}

		public float StandbyDurationInSeconds()
		{
			return 0f;
		}

		public float FlyDurationInSeconds()
		{
			return 0f;
		}

		public float ScaleStartTime()
		{
			return 0f;
		}

		public float FlyTime()
		{
			return 0f;
		}

		public Character1Skill6Version2Info Clone()
		{
			return null;
		}
	}
}
