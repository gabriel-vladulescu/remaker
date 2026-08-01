using System;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class MovementInfo
	{
		[SerializeField]
		public Vector2 distanceX;

		[SerializeField]
		public Vector2 distanceY;

		[SerializeField]
		public bool enable;

		[SerializeField]
		public bool overrideSpeed;

		[SerializeField]
		public float speed;

		[SerializeField]
		public bool enableGraph;

		public Vector2[] controlPoint;
	}
}
