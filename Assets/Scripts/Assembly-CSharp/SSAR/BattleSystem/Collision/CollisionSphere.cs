using System;
using UnityEngine;

namespace SSAR.BattleSystem.Collision
{
	[Serializable]
	public class CollisionSphere
	{
		public Vector2 offset;

		public bool isFeet;

		public bool isHead;

		public CollisionSphere(Vector2 offset, bool isFeet, bool isHead)
		{
		}
	}
}
