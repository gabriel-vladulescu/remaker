using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestDiskUtils : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTests_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TestDiskUtils _003C_003E4__this;

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
		public _003CTests_003Ed__6(int _003C_003E1__state)
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

	[SerializeField]
	private TextMesh text;

	private string obj;

	private void PrintDebug(string str)
	{
	}

	private void PrintDebugLn(string str = "")
	{
	}

	private void Update()
	{
	}

	private void PrintStorageStats()
	{
	}

	[IteratorStateMachine(typeof(_003CTests_003Ed__6))]
	private IEnumerator Tests()
	{
		return null;
	}
}
