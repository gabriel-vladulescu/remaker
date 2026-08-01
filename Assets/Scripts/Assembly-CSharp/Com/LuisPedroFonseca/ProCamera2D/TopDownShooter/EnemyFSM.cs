using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	[RequireComponent(typeof(EnemySight))]
	[RequireComponent(typeof(EnemyWander))]
	[RequireComponent(typeof(EnemyAttack))]
	public class EnemyFSM : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHitAnim_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyFSM _003C_003E4__this;

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
			public _003CHitAnim_003Ed__13(int _003C_003E1__state)
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

		public int Health;

		public Color AttackColor;

		public DoorKey Key;

		private EnemySight _sight;

		private EnemyAttack _attack;

		private EnemyWander _wander;

		private Renderer[] _renderers;

		private Color _originalColor;

		private Color _currentColor;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Hit(int damage)
		{
		}

		[IteratorStateMachine(typeof(_003CHitAnim_003Ed__13))]
		private IEnumerator HitAnim()
		{
			return null;
		}

		private void OnPlayerInSight(Transform obj)
		{
		}

		private void OnPlayerOutOfSight()
		{
		}

		private void Colorize(Color color)
		{
		}

		private void DropLoot()
		{
		}

		private void Die()
		{
		}
	}
}
