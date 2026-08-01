using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Stages.Challenges;
using Assets.Scripts.Ssar.Dungeon.Stages.Goals;
using Assets.Scripts.Ssar.Dungeon.Stages.LosingConditions;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages
{
	public class DefaultStage
	{
		public delegate void WaveCycleDelegate(int waveOrder, WaveCycle waveCycle);

		private class UpdateCounter
		{
			private int rate;

			private int updateCounter;

			private float accumulatedDt;

			private float previousAccumulatedDt;

			public UpdateCounter(int rate)
			{
			}

			public void Update(float dt)
			{
			}

			public bool IsAvailable()
			{
				return false;
			}

			public float PreviousAccumulatedDt()
			{
				return 0f;
			}
		}

		private class Wave
		{
			private int order;

			private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

			private List<Challenge> challenges;

			public int Order => 0;

			public Wave(int order, Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
			{
			}

			public void Update(float dt)
			{
			}

			public void AddChallenge(Challenge c)
			{
			}

			public bool IsFinish()
			{
				return false;
			}
		}

		public enum WaveCycle
		{
			Start = 0
		}

		public const int UPDATE_RATE = 1;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private List<Goal> goals;

		private List<LosingCondition> losingConditions;

		private List<Challenge> challenges;

		private List<Challenge> challengesUnaffectedByWave;

		private NotNullReference notNullReference;

		private StageResult stageResult;

		private UpdateCounter updateCounter;

		private List<Wave> waves;

		private int currentWave;

		private bool firstWaveStart;

		private event WaveCycleDelegate waveCycleEvent;

		public DefaultStage(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public StageResult EvaluationResult()
		{
			return default(StageResult);
		}

		public void AddGoal(Goal goal)
		{
		}

		public void AddLosingCondition(LosingCondition losingCondition)
		{
		}

		public void AddChallenge(int waveOrder, Challenge challenge)
		{
		}

		public void ResetResult()
		{
		}

		public void Update(float dt)
		{
		}

		public static bool IsWaveOrderUnaffectedByWaveLogic(int waveOrder)
		{
			return false;
		}

		private void UpdateChallenges(float previousAccumulatedDt)
		{
		}

		private void AddChallengeToWavesList(int waveOrder, Challenge challenge)
		{
		}

		private void SetCurrentWaveToMinWaveOrder(int waveOrder)
		{
		}

		private void UpdateWaves(float dt)
		{
		}

		public bool IsAllChallengesFinished()
		{
			return false;
		}

		public void ListenToWaveCycle(WaveCycleDelegate listener)
		{
		}

		public void UnlistenToWaveCycle(WaveCycleDelegate listener)
		{
		}

		private void NotifyWaveStart(int order)
		{
		}

		private void UpdateLosingConditions(float dt)
		{
		}

		private void UpdateGoals(float dt)
		{
		}

		private bool EvaluateAllGoalsIsAchieved()
		{
			return false;
		}

		private bool EvaluateAnyLosingConditionsMet()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
