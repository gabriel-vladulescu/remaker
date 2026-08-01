using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController
{
	[CompilerGenerated]
	private sealed class _003CGetFirstFrame_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoPlayerController _003C_003E4__this;

		public Action<Texture> firstFrameCallBack;

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
		public _003CGetFirstFrame_003Ed__8(int _003C_003E1__state)
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
	private sealed class _003CPlayVideo_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoPlayerController _003C_003E4__this;

		private WaitForSeconds _003CwaitTime_003E5__2;

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
		public _003CPlayVideo_003Ed__7(int _003C_003E1__state)
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

	private VideoPlayer videoPlayer;

	private AudioSource audioSource;

	private Action onFinish;

	private int width;

	private int height;

	private UITexture render;

	public VideoPlayerController(GameObject parent, int width, int height, UITexture render, string fileNamePath, Action onFinish)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayVideo_003Ed__7))]
	public IEnumerator PlayVideo()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetFirstFrame_003Ed__8))]
	public IEnumerator GetFirstFrame(Action<Texture> firstFrameCallBack)
	{
		return null;
	}

	private void Resize(UITexture texture, int width, int height)
	{
	}

	public void Stop()
	{
	}
}
