using System;
using System.Collections.Generic;
using UnityEngine;

public class UniWebViewEventProcessor : MonoBehaviour
{
	private object _queueLock;

	private List<Action> _queuedEvents;

	private List<Action> _executingEvents;

	private static UniWebViewEventProcessor _instance;

	public static UniWebViewEventProcessor instance => null;

	public void QueueEvent(Action action)
	{
	}

	private void Update()
	{
	}

	private void MoveQueuedEventsToExecuting()
	{
	}
}
