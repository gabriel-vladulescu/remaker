using UnityEngine;

[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : MonoBehaviour
{
	public enum Direction
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum Bound
	{
		Outside = 0,
		Inside = 1
	}

	public Vector3 m_Center;

	public float m_Radius;

	public float m_Height;

	public Direction m_Direction;

	public Bound m_Bound;

	private void OnValidate()
	{
	}

	public void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
