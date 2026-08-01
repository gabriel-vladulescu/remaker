using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.System.Event.Component;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	public class SoundEffectsPlayer
	{
		private class Controller
		{
			private bool isActive;

			public bool IsActive => false;

			public void Deactivate()
			{
			}

			public void Activate()
			{
			}
		}

		private class RunController : Controller
		{
			private int playedIndex;

			public int PlayedIndex => 0;

			public void IncreaseIndex()
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

		[CompilerGenerated]
		private sealed class _003CWaitThenLoop_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public float interval;

			public Controller controller;

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
			public _003CWaitThenLoop_003Ed__19(int _003C_003E1__state)
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

		private static string[] PREVIOUS_STATE_NAME;

		private HeroStateMachine heroStateMachine;

		private SoundEffectFollowCharacterState config;

		private RoutineRunner routineRunner;

		private CharacterEvent characterEvent;

		private string previousStateName;

		private RunController runningController;

		private Dictionary<string, AudioClip> runClipsByPaths;

		private SoundEffectFollowCharacterState originalConfig;

		private bool isRunState;

		public SoundEffectsPlayer(HeroStateMachine heroStateMachine, SoundEffectFollowCharacterState config, RoutineRunner routineRunner, CharacterEvent characterEvent)
		{
		}

		public void ChangeConfigTo(SoundEffectFollowCharacterState newConfig)
		{
		}

		public void ReturnToOriginalConfig()
		{
		}

		private void OnStateTransition(string oldStateName, string newStateName, bool resume)
		{
		}

		private void PlayRunSfx()
		{
		}

		private void StopPlayingRunSfx()
		{
		}

		private void PlayRunLoop(int frame, string[] path, float interval, RunController controller, Action onInvocation = null, Action<string, AudioClip> callback = null)
		{
		}

		private void PlaySound(int frame, string path)
		{
		}

		public void Update(float deltaTime)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenLoop_003Ed__19))]
		private IEnumerator WaitThenLoop(float waitTime, Action action, float interval, Controller controller)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitThenInvoke_003Ed__20))]
		private IEnumerator WaitThenInvoke(float waitTime, Action action)
		{
			return null;
		}
	}
}
