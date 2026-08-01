using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Utilities/HUDFPS")]
public class HUDFPS : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFPS_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDFPS _003C_003E4__this;

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
		public _003CFPS_003Ed__23(int _003C_003E1__state)
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

	private Rect startRect;

	public bool updateColor;

	public bool allowDrag;

	public float frequency;

	public int nbDecimal;

	private float accum;

	private int frames;

	private Color color;

	private string sFPS;

	private GUIStyle style;

	public static HUDFPS instance;

	public float minFps;

	public float maxFps;

	public int below10Fps;

	public int below20Fps;

	private bool isTrackingFps;

	public bool Enable { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CFPS_003Ed__23))]
	private IEnumerator FPS()
	{
		return null;
	}

	private void OnGUI()
	{
	}

	private void DoMyWindow(int windowID)
	{
	}

	public void StartTrackFps()
	{
	}

	public void StopTrackFps()
	{
	}
}
