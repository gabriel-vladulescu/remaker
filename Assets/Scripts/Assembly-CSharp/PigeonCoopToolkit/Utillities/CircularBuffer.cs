using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PigeonCoopToolkit.Utillities
{
	public class CircularBuffer<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__19 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public CircularBuffer<T> _003C_003E4__this;

			private long _003Cversion_003E5__2;

			private int _003Ci_003E5__3;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CGetEnumerator_003Ed__19(int _003C_003E1__state)
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

		private T[] _buffer;

		private int _position;

		private long _version;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public int Capacity { get; private set; }

		public int Count { get; private set; }

		bool ICollection<T>.IsReadOnly => false;

		public CircularBuffer(int capacity)
		{
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[IteratorStateMachine(typeof(CircularBuffer<>._003CGetEnumerator_003Ed__19))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
