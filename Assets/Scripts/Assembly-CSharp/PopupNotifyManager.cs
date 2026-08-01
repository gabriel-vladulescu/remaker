using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;

public class PopupNotifyManager
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public PopupNotifyManager _003C_003E4__this;

		public List<AbsPopupNotify> list;

		public Action onComplete;

		public bool isBreak;

		public Action _003C_003E9__1;

		internal void _003CShowPopup_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public int i;

		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		internal void _003CShowPopup_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowPopup_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNotifyManager _003C_003E4__this;

		public Action onComplete;

		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		public string sceneName;

		private _003C_003Ec__DisplayClass8_1 _003C_003E8__2;

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
		public _003CShowPopup_003Ed__8(int _003C_003E1__state)
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

	private Dictionary<string, List<AbsPopupNotify>> dic;

	private bool next;

	private string sceneName;

	public bool isInSequence;

	public void Setup(ConfigManager configManager)
	{
	}

	private void AddAbsNotify(AbsPopupNotify notify)
	{
	}

	public void Check(string sceneName, Action onComplete)
	{
	}

	[IteratorStateMachine(typeof(_003CShowPopup_003Ed__8))]
	private IEnumerator ShowPopup(string sceneName, Action onComplete)
	{
		return null;
	}

	private void Complete(Action onComplete)
	{
	}

	private List<AbsPopupNotify> GetListNotify(string sceneName)
	{
		return null;
	}

	private bool HasTutorialWithKey(string sceneName)
	{
		return false;
	}

	public string GetCurrentSceneName()
	{
		return null;
	}

	private void BundlePackageNotify(ConfigManager configManager)
	{
	}

	private void NewFeatureNotify(ConfigManager configManager)
	{
	}
}
