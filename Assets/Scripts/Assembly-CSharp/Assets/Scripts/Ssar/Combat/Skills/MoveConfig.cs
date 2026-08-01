using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class MoveConfig
	{
		public bool useCurve;

		public AnimationCurve curve;

		public float maxSpeed;
	}
}
