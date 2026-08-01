using UnityEngine;

public class TextMover : MonoBehaviour
{
	[SerializeField]
	private float speed;

	private void Update()
	{
	}

	private void GetMobile(out float h, out float v)
	{
		h = default(float);
		v = default(float);
	}

	private void GetDesktop(out float h, out float v)
	{
		h = default(float);
		v = default(float);
	}
}
