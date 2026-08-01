using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Ssar.Common.System.RoutineRunner
{
	public interface RoutineRunner
	{
		Coroutine StartCoroutine(IEnumerator iterationResult, bool canStopWhenClearScene = true);

		void StopCoroutine(IEnumerator iterationResult);

		void PauseAllCoroutine();

		void ResumeAllCoroutine();
	}
}
