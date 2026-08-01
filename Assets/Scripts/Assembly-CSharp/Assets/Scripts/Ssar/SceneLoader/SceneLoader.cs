using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.SceneLoader.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.SceneLoader
{
	public class SceneLoader
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<AsyncOperation> onFinish;

			public AsyncOperation asyncOperation;

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
			public _003CDelay_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CDelayInvokeFinish_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadSceneRequest request;

			public SceneLoader _003C_003E4__this;

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
			public _003CDelayInvokeFinish_003Ed__10(int _003C_003E1__state)
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
		private sealed class _003CLoadLoadingScene_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneLoader _003C_003E4__this;

			public LoadingModeType loadingModeType;

			public Action<LoadingSceneView> onFinish;

			private LoadingSceneView _003Cview_003E5__2;

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
			public _003CLoadLoadingScene_003Ed__15(int _003C_003E1__state)
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
		private sealed class _003CPreloadScene_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string sceneName;

			public float time;

			public Action<float> progress;

			public SceneLoader _003C_003E4__this;

			public Action<AsyncOperation> onFinish;

			private AsyncOperation _003CasyncOperation_003E5__2;

			private bool _003Creached_003E5__3;

			private float _003CfakeProgress_003E5__4;

			private float _003CmaxProgress_003E5__5;

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
			public _003CPreloadScene_003Ed__12(int _003C_003E1__state)
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

		public static float SCENE_PERCENTAGE;

		public static float ASSETS_PERCENTAGE;

		private float curProgress;

		private LoadingSceneView loadingSceneView;

		private LoadSceneRequest currentRequest;

		public void LoadScene(LoadSceneRequest request)
		{
		}

		public void ForceDestroyLoadingScreen()
		{
		}

		private void DoLoadSceneRequire(LoadSceneRequest request)
		{
		}

		private void DoPreloadSceneAssets(LoadSceneRequest request)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayInvokeFinish_003Ed__10))]
		private IEnumerator DelayInvokeFinish(LoadSceneRequest request)
		{
			return null;
		}

		private void AddProgress(float progress)
		{
		}

		[IteratorStateMachine(typeof(_003CPreloadScene_003Ed__12))]
		private IEnumerator PreloadScene(string sceneName, Action<float> progress, Action<AsyncOperation> onFinish, float time = 0f)
		{
			return null;
		}

		private void Finish(Action<AsyncOperation> onFinish, AsyncOperation asyncOperation)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__14))]
		private IEnumerator Delay(Action<AsyncOperation> onFinish, AsyncOperation asyncOperation)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadLoadingScene_003Ed__15))]
		private IEnumerator LoadLoadingScene(Action<LoadingSceneView> onFinish, LoadingModeType loadingModeType)
		{
			return null;
		}
	}
}
