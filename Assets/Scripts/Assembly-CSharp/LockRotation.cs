using UnityEngine;

public class LockRotation : MonoBehaviour
{
	public bool lockX;

	public bool lockY;

	public bool lockZ;

	private Vector3 _originalRot;

	private Transform _trans;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
