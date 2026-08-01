using UnityEngine;

public class Z_Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance;

	private static bool _isQuit;

	public static T Instance => null;

	public void Reset()
	{
	}

	public static bool Exists()
	{
		return false;
	}

	public void OnDestroy()
	{
	}
}
