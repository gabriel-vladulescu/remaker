using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.EditorExtensions.Effects
{
	[Serializable]
	public class ShurikenToSpritesheetRenderer : MonoBehaviour
	{
		public delegate void onFrameRenderEventHandler();

		[CompilerGenerated]
		private sealed class _003CcreateSpritesheetCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShurikenToSpritesheetRenderer _003C_003E4__this;

			public int frameCaptureTextureSize;

			public Camera camera;

			public int spritesheetTextureSize;

			public List<ParticleSystem> particleSystems;

			public bool[] particleSystemsPrewarm;

			public float currentPlaybackPosition;

			public float spritesheetAnimationDuration;

			public float colourPostmultiplier;

			public string path;

			public bool openFileOnComplete;

			private Texture2D _003CblackFrame_003E5__2;

			private Texture2D _003CspritesheetTexture_003E5__3;

			private CameraClearFlags _003CcameraClearFlags_003E5__4;

			private Color _003CcameraBackgroundColour_003E5__5;

			private int _003CframesPerAxis_003E5__6;

			private int _003CframesInSpritesheet_003E5__7;

			private Texture2D _003CwhiteFrame_003E5__8;

			private Texture2D _003CalphaFrame_003E5__9;

			private int _003Ci_003E5__10;

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
			public _003CcreateSpritesheetCoroutine_003Ed__12(int _003C_003E1__state)
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

		private RenderTexture renderTexture;

		public float progress { get; set; }

		public event onFrameRenderEventHandler onFrameRenderEvent;

		private void Awake()
		{
		}

		private void resetParticleSystems(List<ParticleSystem> particleSystems, bool[] particleSystemsPrewarm)
		{
		}

		public void createSpritesheet(string path, int frameCaptureTextureSize, int spritesheetTextureSize, float spritesheetAnimationDuration, float colourPremultiplier, float colourPostmultiplier, float currentPlaybackPosition, List<ParticleSystem> particleSystems, bool[] particleSystemsPrewarm, Camera camera, bool openFileOnComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CcreateSpritesheetCoroutine_003Ed__12))]
		private IEnumerator createSpritesheetCoroutine(string path, int frameCaptureTextureSize, int spritesheetTextureSize, float spritesheetAnimationDuration, float colourPremultiplier, float colourPostmultiplier, float currentPlaybackPosition, List<ParticleSystem> particleSystems, bool[] particleSystemsPrewarm, Camera camera, bool openFileOnComplete)
		{
			return null;
		}
	}
}
