using UnityEngine;

namespace SSAR.BattleSystem.System.Collision
{
	public class RectangleCollider : ICollider
	{
		public Vector2 size;

		public Quaternion rotation;

		public RectangleCollider(float width, float height)
		{
		}

		public RectangleCollider(float width, float height, Quaternion rotation)
		{
		}
	}
}
