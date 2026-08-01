using System;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class AIMateralFloatEfect
	{
		[SerializeField]
		public float to;

		[SerializeField]
		public float duration;

		[SerializeField]
		public AnimationCurve animationCurve;

		public bool useEffect;
	}
}
