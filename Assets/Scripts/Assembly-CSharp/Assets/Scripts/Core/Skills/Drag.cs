using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class Drag
	{
		private float duration;

		private float radius;

		private Vector2 dragPositionOffset;

		public float Duration => 0f;

		public float Radius => 0f;

		public Vector2 DragPositionOffset => default(Vector2);

		public Drag(float duration, float radius, Vector2 dragPositionOffset)
		{
		}
	}
}
