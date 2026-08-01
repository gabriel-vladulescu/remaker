using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinerInstance : MonoBehaviour
{
	public List<CoroutineController> coroutineController;

	private void Awake()
	{
	}

	public Coroutine ProcessWork(IEnumerator routine, bool canStopWhenClearScene, Action onFinish)
	{
		return null;
	}

	public void StopAllCoroutine()
	{
	}
}
