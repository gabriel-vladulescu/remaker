using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace crosspromotion
{
	public class CrossPromotion
	{
		[CompilerGenerated]
		private sealed class _003CDelayOpenApp_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CrossPromotionItemConfig item;

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
			public _003CDelayOpenApp_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CLoadConfig_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string domain;

			public Action<bool, string> callback;

			private WWW _003Cw_003E5__2;

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
			public _003CLoadConfig_003Ed__15(int _003C_003E1__state)
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

		private static string fileName;

		private static UniWebView _webView;

		private static CrossPromotionConfig crossPromotionConfig;

		private static Action<Error, string> errorAction;

		private static Action<string, int> rewardAction;

		private static Action onOpen;

		private static Action onClose;

		private static Action<Interact, CrossPromotionItemConfig> interact;

		private static CrossPromotionData data;

		public static void ListenError(Action<Error, string> action)
		{
		}

		public static void ListenClaimReward(Action<string, int> action)
		{
		}

		public static void ListenInteractAction(Action<Interact, CrossPromotionItemConfig> action)
		{
		}

		public static void ListenOnOpenAction(Action action)
		{
		}

		public static void ListenOnCloseAction(Action action)
		{
		}

		public static void Show(string domain)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadConfig_003Ed__15))]
		private static IEnumerator LoadConfig(string domain, Action<bool, string> callback)
		{
			return null;
		}

		private static void CheckCrosspromotionStatus(CrossPromotionData data, bool isInit)
		{
		}

		private static void CheckCrosspromotionStatus(CrossPromotionData data, CrossPromotionItemConfig item, bool isInit)
		{
		}

		private static void OpenWebview(string domain)
		{
		}

		private static void OnReceivedMessage(UniWebView webView, UniWebViewMessage message)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayOpenApp_003Ed__20))]
		private static IEnumerator DelayOpenApp(CrossPromotionItemConfig item)
		{
			return null;
		}

		private static void Close(UniWebView webView)
		{
		}

		private static UniWebView CreateWebView()
		{
			return null;
		}

		private static CrossPromotionData LoadUserData()
		{
			return null;
		}

		private static bool HasUserData()
		{
			return false;
		}

		private static string FilePath()
		{
			return null;
		}

		private static void Save(CrossPromotionData d)
		{
		}
	}
}
