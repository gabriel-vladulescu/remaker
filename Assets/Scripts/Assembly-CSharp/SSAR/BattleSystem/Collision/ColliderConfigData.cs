using UnityEngine;

namespace SSAR.BattleSystem.Collision
{
	public class ColliderConfigData : MonoBehaviour
	{
		[SerializeField]
		private bool debugSpheres;

		[SerializeField]
		public CollisionSphere[] spheres;

		[SerializeField]
		public Collider ownCollider;

		[SerializeField]
		public float radius;

		private CollisionSphere head;

		private CollisionSphere body;

		private CollisionSphere feet;

		private void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public CollisionSphere GetHeadSphere()
		{
			return null;
		}

		public CollisionSphere GetBodySphere()
		{
			return null;
		}

		public CollisionSphere GetFeetSphere()
		{
			return null;
		}
	}
}
