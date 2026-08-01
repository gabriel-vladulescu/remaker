using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.Camera;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Mimic
{
	public class MimicLogic
	{
		[CompilerGenerated]
		private sealed class _003CUpdateVfxPos_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MimicLogic _003C_003E4__this;

			private float _003Cdt_003E5__2;

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
			public _003CUpdateVfxPos_003Ed__21(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitThenInvoke_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public Action action;

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
			public _003CWaitThenInvoke_003Ed__20(int _003C_003E1__state)
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

		private const float WAIT_TIME = 4f;

		private const float NOTIFICATION_DURATION = 2f;

		private IDungeonInfo dungeonInfo;

		private InitDungeonSystemCmd.SpawnedMonsterList spawnedMonsterList;

		private SpawnMonsterSignal spawnMonsterSignal;

		private CameraComponent cameraComponent;

		private DungeonConfig dungeonConfig;

		private JsonRandomEquipmentConfig randomEquipmentConfig;

		private RoutineRunner routineRunner;

		private int spawnCount;

		private int spawnTicketId;

		private Entity mimicEntity;

		private GameObject vfx;

		private float vfxElapsed;

		public MimicLogic(IDungeonInfo dungeonInfo, InitDungeonSystemCmd.SpawnedMonsterList spawnedMonsterList, SpawnMonsterSignal spawnMonsterSignal, CameraComponent cameraComponent, DungeonConfig dungeonConfig, JsonRandomEquipmentConfig randomEquipmentConfig, RoutineRunner routineRunner)
		{
		}

		public void OnStageCycle(int stageOrder, Dungeon.StageCycle cycle)
		{
		}

		public void OnEntityDeath(Entity deadEntity)
		{
		}

		private void Notify()
		{
		}

		private bool DecideMimicAppearance(int stageOrder, Dungeon.StageCycle cycle)
		{
			return false;
		}

		private void SpawnMimic(int stageOrder, Dungeon.StageCycle cycle)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenInvoke_003Ed__20))]
		private IEnumerator WaitThenInvoke(float waitTime, Action action)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUpdateVfxPos_003Ed__21))]
		private IEnumerator UpdateVfxPos()
		{
			return null;
		}
	}
}
