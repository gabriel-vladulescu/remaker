using System.Runtime.CompilerServices;
using UnityEngine;

public class DispatcherRunner : MonoBehaviour
{
	public delegate void OnApplicationPauseEvent(bool pauseStatus);

	public delegate void OnAwakeEvent();

	public delegate void OnApplicationQuitEvent();

	public delegate void OnLevelWasLoadedEvent(int level);

	public event OnApplicationPauseEvent OnApplicationPauseHandler;

	public event OnApplicationQuitEvent OnApplicationQuitHandler;

	public event OnAwakeEvent OnAwakeHandler;

	public event OnLevelWasLoadedEvent OnLevelWasLoadedHandler;

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnLevelWasLoaded(int level)
	{
	}
}
