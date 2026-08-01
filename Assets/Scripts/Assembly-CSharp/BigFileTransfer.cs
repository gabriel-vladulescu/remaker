using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

public class BigFileTransfer
{
	public delegate void OnWriteComplete(bool success);

	[CompilerGenerated]
	private sealed class _003CNowCheckForResourceUnload_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BigFileTransfer _003C_003E4__this;

		public string savePath;

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
		public _003CNowCheckForResourceUnload_003Ed__2(int _003C_003E1__state)
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

	private Dictionary<string, byte[]> dataPool;

	private Dictionary<string, Thread> threadPool;

	private Dictionary<string, bool> completedFlagPool;

	private Dictionary<string, OnWriteComplete> callbackPool;

	public void WriteAllBytesAsync(byte[] data, string savePath, OnWriteComplete callback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CNowCheckForResourceUnload_003Ed__2))]
	private IEnumerator NowCheckForResourceUnload(string savePath)
	{
		return null;
	}

	private void SaveDataThreaded(string savePath)
	{
	}

	private void SaveDataTaskThreaded(string savePath)
	{
	}

	private void CallCB(string savePath, bool flag)
	{
	}
}
