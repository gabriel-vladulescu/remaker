using System.Collections;
using UnityEngine;

namespace crosspromotion
{
	public class Coroutiner
	{
		private static CoroutinerInstance cache;

		private static GameObject coroutineContainer;

		public static Coroutine StartCoroutine(IEnumerator iterationResult, bool canStopWhenClearScene = true)
		{
			return null;
		}

		public static void StopCoroutine(IEnumerator iterationResult)
		{
		}

		public static void StopAllCoroutine()
		{
		}

		public static void PauseAllCoroutine()
		{
		}

		public static void ResumeAllCoroutine()
		{
		}
	}
}
