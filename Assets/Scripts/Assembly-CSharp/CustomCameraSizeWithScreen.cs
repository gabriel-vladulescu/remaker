using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CustomCameraSizeWithScreen : MonoBehaviour
{
	public float screen4_3;

	public float screen3_2;

	public float screen16_9;

	public float screen17_10;

	public float screen5_3;

	public float screen16_10;

	public float screen37_18;

	private Dictionary<float, float> map;

	private void Start()
	{
	}

	private void AutoScale()
	{
	}

	[ContextMenu("Execute")]
	public virtual void ExecuteScale()
	{
	}
}
