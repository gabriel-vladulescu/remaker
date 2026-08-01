using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ssar.RaidBoss.Command;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidFindPartyPopup : BasePopup
	{
		[CompilerGenerated]
		private sealed class _003CStartOffline_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RaidFindPartyPopup _003C_003E4__this;

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
			public _003CStartOffline_003Ed__15(int _003C_003E1__state)
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

		public GameObject loadingFx;

		public RaidPreviewCompanionView previewCompanionView;

		public UILabel lbTitle;

		public GameObject btnClose;

		public GameObject btnStart;

		public GameObject btnRefind;

		private ShowRaidFindPartyPopupParameter parameter;

		private new void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		private void ClickClose(GameObject go)
		{
		}

		private void ClickRefind(GameObject go)
		{
		}

		private void ClickStart(GameObject go)
		{
		}

		public void Show(ShowRaidFindPartyPopupParameter parameter)
		{
		}

		internal void OnLoadedData(MainCharacterData characterData)
		{
		}

		[IteratorStateMachine(typeof(_003CStartOffline_003Ed__15))]
		private IEnumerator StartOffline()
		{
			return null;
		}
	}
}
