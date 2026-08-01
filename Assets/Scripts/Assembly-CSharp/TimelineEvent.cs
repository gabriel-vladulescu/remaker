using System;

public class TimelineEvent
{
	private float elapsed;

	private float timeToOccur;

	private Action action;

	private bool isOccured;

	public TimelineEvent(float timeToOccur, Action action)
	{
	}

	public TimelineEvent(float elapsed, float timeToOccur, Action action)
	{
	}

	public void OnElapsed(float seconds)
	{
	}
}
