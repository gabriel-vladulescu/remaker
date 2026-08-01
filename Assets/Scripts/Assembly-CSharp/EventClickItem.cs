using System;
using UnityEngine;

public class EventClickItem : MonoBehaviour
{
	public GameObject wgActive;

	public GameObject wgInActive;

	public Action<int> OnClick;

	private int currentIndex;

	private void Awake()
	{
	}

	public void RegisterIndex(Action<int> onClick, int index)
	{
	}

	public void SetItemActiveMark(bool active)
	{
	}

	private void Click(GameObject go)
	{
	}
}
