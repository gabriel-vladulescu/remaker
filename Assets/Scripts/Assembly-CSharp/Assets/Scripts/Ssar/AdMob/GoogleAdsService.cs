using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Ssar.AdMob
{
	public class GoogleAdsService : IAdsService
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GoogleAdsService _003C_003E4__this;

			public RewardVideoResult rewardVideoResult;

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
			public _003CWait_003Ed__12(int _003C_003E1__state)
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

		private string bannerId;

		private string interstitialId;

		private string videoRewardedId;

		private bool testMode;

		private Action<RewardVideoResult> callBack;

		private bool hasReward;

		public GoogleAdsService(string bannerId, string interstitialId, string videoRewardedId, bool testMode)
		{
		}

		public void Initialize()
		{
		}

		public void RequestRewardVideo()
		{
		}

		public bool IsRewardVideoAlready()
		{
			return false;
		}

		public void ShowRewardVideo(Action<RewardVideoResult> callBack)
		{
		}

		private void InvokeCallBack(RewardVideoResult rewardVideoResult)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__12))]
		private IEnumerator Wait(RewardVideoResult rewardVideoResult)
		{
			return null;
		}
	}
}
