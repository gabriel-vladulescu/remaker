using UnityEngine;

public class BaseTransformation : MonoBehaviour
{
	public Vector3 axis;

	public Space space;

	public float duration;

	protected Transform trans;

	protected bool isCreated;

	protected virtual void OnEnable()
	{
	}
}
