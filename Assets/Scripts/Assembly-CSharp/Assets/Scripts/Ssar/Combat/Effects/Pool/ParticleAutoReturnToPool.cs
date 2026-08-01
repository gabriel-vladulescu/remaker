using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects.Pool
{
	public class ParticleAutoReturnToPool : MonoBehaviour
	{
		private class CoroutineWithId
		{
			[CompilerGenerated]
			private sealed class _003CCheckIfAlive_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public CoroutineWithId _003C_003E4__this;

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
				public _003CCheckIfAlive_003Ed__10(int _003C_003E1__state)
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
			private sealed class _003CCountdownToDeath_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public CoroutineWithId _003C_003E4__this;

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
				public _003CCountdownToDeath_003Ed__9(int _003C_003E1__state)
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

			public float timeToLive;

			private int id;

			private ParticleAutoReturnToPool partp;

			private float elapsed;

			private ParticleSystem[] particle;

			private bool isAlive;

			public CoroutineWithId(float timeToLive, int id, ParticleAutoReturnToPool partp)
			{
			}

			public void StartCountDownToDeath()
			{
			}

			public void StartCheckIfAlive()
			{
			}

			[IteratorStateMachine(typeof(_003CCountdownToDeath_003Ed__9))]
			private IEnumerator CountdownToDeath()
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CCheckIfAlive_003Ed__10))]
			private IEnumerator CheckIfAlive()
			{
				return null;
			}
		}

		public float timeToLive;

		public bool isScaled;

		private float scaleFactor;

		private List<float> initParticleScale;

		private EffectPool ep;

		private int coroutineId;

		private bool destroyed;

		public void OnCreate(EffectPool ep)
		{
		}

		protected virtual void OnEnable()
		{
		}

		public void OnExit(int id)
		{
		}

		public void OnExit()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void DescaleEffect()
		{
		}

		private ParticleSystem[] GetParticle()
		{
			return null;
		}

		private void Log(string s)
		{
		}
	}
}
