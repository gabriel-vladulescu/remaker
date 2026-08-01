using System;
using UnityEngine;

public class UnbiasedTime : MonoBehaviour
{
	private static UnbiasedTime instance;

	[HideInInspector]
	public long timeOffset;

	public static UnbiasedTime Instance => null;

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public DateTime Now()
	{
		return default(DateTime);
	}

	public void UpdateTimeOffset()
	{
	}

	public bool IsUsingSystemTime()
	{
		return false;
	}

	private void SessionStart()
	{
	}

	private void SessionEnd()
	{
	}

	private void UpdateTimeOffsetAndroid()
	{
	}

	private void StartAndroid()
	{
	}

	private void EndAndroid()
	{
	}

	private bool UsingSystemTimeAndroid()
	{
		return false;
	}
}
