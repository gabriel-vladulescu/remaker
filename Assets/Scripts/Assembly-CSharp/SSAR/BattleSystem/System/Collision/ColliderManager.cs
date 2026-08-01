using System.Collections.Generic;
using Artemis;
using UnityEngine;

namespace SSAR.BattleSystem.System.Collision
{
	public class ColliderManager
	{
		private class EntityValidator : IValidator
		{
			public bool IsCondition(Collider collider)
			{
				return false;
			}
		}

		private class ObstacleValidator : IValidator
		{
			private List<int> uiLayer;

			public bool IsCondition(Collider collider)
			{
				return false;
			}
		}

		private class DefaultValidator : IValidator
		{
			private List<int> uiLayer;

			public bool IsCondition(Collider collider)
			{
				return false;
			}
		}

		private interface IValidator
		{
			bool IsCondition(Collider collider);
		}

		public static List<Entity> GetEntitiesCollide(Vector3 position, ICollider collider, Quaternion quaternion)
		{
			return null;
		}

		public static List<Entity> GetEntitiesCollide(Vector3 position, ICollider collider)
		{
			return null;
		}

		public static List<Collider> GetObstacleCollide(Vector3 position, ICollider collider)
		{
			return null;
		}

		public static List<Collider> GetObstacleCollide(Vector3 position, ICollider collider, Quaternion quaternion)
		{
			return null;
		}

		private static Collider[] BoxOverlap(Vector3 position, RectangleCollider rectangleCollider, Quaternion quaternion)
		{
			return null;
		}

		private static Collider[] CircleOverlap(Vector3 position, CircleCollider circleCollider)
		{
			return null;
		}

		private static List<Collider> ColliderOverlap(Vector3 position, ICollider collider, IValidator validator, Quaternion quaternion)
		{
			return null;
		}
	}
}
