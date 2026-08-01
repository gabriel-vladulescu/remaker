using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Ssar.Common.System.RoutineRunner
{
	public class RoutineRunnerSubSystem : SubSystem, RoutineRunner
	{
		private class Host : MonoBehaviour
		{
		}

		private Host host;

		public void StartUp()
		{
			GameObject go = new GameObject("RoutineRunnerSubSystem");
			UnityEngine.Object.DontDestroyOnLoad(go);
			host = go.AddComponent<Host>();
		}

		public void ShutDown()
		{
			if (host != null)
			{
				UnityEngine.Object.Destroy(host.gameObject);
				host = null;
			}
		}

		public Coroutine StartCoroutine(IEnumerator iterationResult, bool canStopWhenClearScene = true)
		{
			return host != null ? host.StartCoroutine(iterationResult) : null;
		}

		public void StopCoroutine(IEnumerator iterationResult)
		{
			if (host != null)
			{
				host.StopCoroutine(iterationResult);
			}
		}

		public void PauseAllCoroutine()
		{
			if (host != null)
			{
				host.StopAllCoroutines();
			}
		}

		public void ResumeAllCoroutine()
		{
		}
	}
}
