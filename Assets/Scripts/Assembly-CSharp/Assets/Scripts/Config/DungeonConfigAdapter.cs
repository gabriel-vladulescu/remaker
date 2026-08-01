using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Checking;

namespace Assets.Scripts.Config
{
	public class DungeonConfigAdapter : DungeonConfig
	{
		[CompilerGenerated]
		private sealed class _003CWaitForLoadDungeon_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitForLoadDungeon_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private RawDungeonConfig rawDungeonConfig;

		private NotNullReference notNullReference;

		private Dictionary<string, Dungeon> dungeons;

		private Dictionary<string, Stage> stages;

		private Dictionary<string, Goal> goals;

		private Dictionary<string, LosingCondition> losingConditions;

		private Dictionary<string, Challenge> challenges;

		private Dictionary<string, Trigger> triggers;

		private Dictionary<string, Gate> gates;

		private Dictionary<string, StageActivator> stageActivators;

		private int counter;

		public DungeonConfigAdapter(RawDungeonConfig rawDungeonConfig, ResourcesLoader resourcesLoader, RoutineRunner routineRunner, Action callback)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForLoadDungeon_003Ed__12))]
		private IEnumerator WaitForLoadDungeon(Action callback)
		{
			return null;
		}

		public IEnumerable<Dungeon> DungeonsList()
		{
			return null;
		}

		public Dungeon GetDungeonById(int dungeonId)
		{
			return null;
		}

		public IEnumerable<Stage> StagesList()
		{
			return null;
		}

		public Stage GetStageById(int stageId)
		{
			return null;
		}

		public IEnumerable<MonsterId> FindMonsterIdsSpawnInDungeon(int dungeonId)
		{
			return null;
		}

		public IEnumerable<Goal> GoalsList()
		{
			return null;
		}

		public Goal GetGoalById(int goalId)
		{
			return null;
		}

		public IEnumerable<LosingCondition> LosingConditionsList()
		{
			return null;
		}

		public LosingCondition GetLosingConditionById(int losingConditionId)
		{
			return null;
		}

		public IEnumerable<Challenge> ChallengesList()
		{
			return null;
		}

		public Challenge GetChallengeById(int challengeId)
		{
			return null;
		}

		public IEnumerable<Trigger> TriggersList()
		{
			return null;
		}

		public Trigger GetTriggerById(int triggerId)
		{
			return null;
		}

		public Gate GetGateById(int gateId)
		{
			return null;
		}

		public IEnumerable<Gate> GatesList()
		{
			return null;
		}

		public StageActivator GetStageActivatorById(int stageActivatorId)
		{
			return null;
		}

		public IEnumerable<StageActivator> StageActivatorsList()
		{
			return null;
		}
	}
}
