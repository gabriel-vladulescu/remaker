using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

public class StreamVideo : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CplayVideo_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StreamVideo _003C_003E4__this;

		public string fileNamePath;

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
		public _003CplayVideo_003Ed__23(int _003C_003E1__state)
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

	public UITexture image;

	public UIWidget size;

	public GameObject btn_skip;

	public GameObject wg_skip;

	public UILabel lb_progress;

	public UILabel lb_text;

	public UIProgressBar ProgressBar;

	private VideoPlayer videoPlayer;

	private VideoSource videoSource;

	private TextLoading textDownloadCOnfig;

	private AudioSource audioSource;

	private StreamVideoParameter parameter;

	private bool showTextDownload;

	private int timeSleep;

	protected override void Awake()
	{
	}

	protected override void onEnable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void OnDisable()
	{
	}

	public void Show(StreamVideoParameter parameter)
	{
	}

	private void Update()
	{
	}

	public void UpdateDownloadProgress(float progress)
	{
	}

	public void FinishDownloadAssets()
	{
	}

	public void HideVideo()
	{
	}

	[IteratorStateMachine(typeof(_003CplayVideo_003Ed__23))]
	private IEnumerator playVideo(string fileNamePath)
	{
		return null;
	}

	private void Skip(GameObject o)
	{
	}

	private void Finish()
	{
	}

	private void Resize()
	{
	}
}
