using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraCacheComponent : MonoBehaviour
{
	private Camera camera;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
