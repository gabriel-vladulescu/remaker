using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CustomPositionWithScreenSize : MonoBehaviour
{
	public Vector3 screen4_3;

	public Vector3 screen3_2;

	public Vector3 screen16_9;

	public Vector3 screen17_10;

	public Vector3 screen5_3;

	public Vector3 screen16_10;

	public Vector3 screen37_18;

	public Vector3 screen39_18;

	private Dictionary<float, Vector3> map;

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
