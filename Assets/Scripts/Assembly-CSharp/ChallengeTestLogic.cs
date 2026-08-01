using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Stages;
using Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers;
using UnityEngine;

public class ChallengeTestLogic : MonoBehaviour
{
	private class DebugLogTrigger : Trigger
	{
		private Trigger original;

		public DebugLogTrigger(Trigger original)
		{
		}

		public bool IsFinished()
		{
			return false;
		}

		public void Update(float dt, int waveOrder)
		{
		}

		public void SetEnv(Environment env)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public string UnfinishedReason()
		{
			return null;
		}
	}

	private DefaultStage defaultStage;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
