using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class CountryRequirement : InterstitialAds.Requirement
	{
		[CompilerGenerated]
		private sealed class _003CCallWebApi_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CountryRequirement _003C_003E4__this;

			private WWW _003Cwww_003E5__2;

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
			public _003CCallWebApi_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CDetectCountry_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CountryRequirement _003C_003E4__this;

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
			public _003CDetectCountry_003Ed__4(int _003C_003E1__state)
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

		private InterstitialData interstitialData;

		private List<string> blackList;

		private List<string> whiteList;

		public CountryRequirement(InterstitialData interstitialData, List<string> blackList, List<string> whiteList)
		{
		}

		[IteratorStateMachine(typeof(_003CDetectCountry_003Ed__4))]
		private IEnumerator DetectCountry()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCallWebApi_003Ed__5))]
		private IEnumerator CallWebApi()
		{
			return null;
		}

		public void Touch()
		{
		}

		public bool IsMet()
		{
			return false;
		}

		public string Reason()
		{
			return null;
		}

		public void OnAdsShown()
		{
		}
	}
}
