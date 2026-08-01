using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Shop.Command;
using SSAR.Shop.Enum;
using UnityEngine;
using strange.extensions.mediation.impl;

public class DrawShopBoughtPopup : View
{
	[Serializable]
	public class FrameData
	{
		public int switchFrame;

		public int endFrame;

		public FrameData(FrameData other)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAutoFlipCard_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrawShopBoughtPopup _003C_003E4__this;

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
		public _003CAutoFlipCard_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CDelayDisable_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrawShopBoughtPopup _003C_003E4__this;

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
		public _003CDelayDisable_003Ed__49(int _003C_003E1__state)
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
	private sealed class _003CDelayReplace_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrawShopBoughtPopup _003C_003E4__this;

		public int i;

		public bool isHighGrade;

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
		public _003CDelayReplace_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003COpenAllRemainCards_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrawShopBoughtPopup _003C_003E4__this;

		private float _003C_delay_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003COpenAllRemainCards_003Ed__39(int _003C_003E1__state)
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

	public GameObject closeBtn;

	public GameObject closeBtnLarge;

	public GameObject openAllBtn;

	public GameObject btnBuyMore;

	public GameObject bgSingle;

	public GameObject bgPack;

	public GameObject packContainer;

	public GameObject packCardContainer;

	public GameObject _3DContainer;

	public FrameData frameSingle;

	public FrameData framePack;

	public Vector3 singleCardOffset;

	public Vector3 cardOffset;

	public Vector3 replaceEffOffset;

	public float fxCardHighDuration;

	private FrameData curFrameData;

	private float duration;

	private GameObject objCardPack;

	private GameObject objCardSingle;

	private Transform[] objCardPackAllJoints;

	private Transform[] objCardSingleAllJoints;

	private Transform[] allJoints;

	private DrawShopBoughtCardView[] cardViews;

	private UITweener shakeTween;

	private ItemInfo[] itemDatas;

	private const int FPS = 30;

	private const int MAX_CARDS = 11;

	private GameObject prefabCardLow;

	private GameObject prefabCardHigh;

	private GameObject prefabReplaceCard;

	private Action onFinish;

	private DrawCardType equipmentType;

	private bool disableWhenFinish;

	private ShowShopTreasureChestFxParameter parameter;

	private new void Awake()
	{
	}

	private void BuyMore(GameObject go)
	{
	}

	private void Close(GameObject o)
	{
	}

	private void OpenAll(GameObject o)
	{
	}

	public void Hide()
	{
	}

	[IteratorStateMachine(typeof(_003COpenAllRemainCards_003Ed__39))]
	private IEnumerator OpenAllRemainCards()
	{
		return null;
	}

	private void SetDoneBtns()
	{
	}

	public void Refresh()
	{
	}

	public void OnDrawHighGradeCard()
	{
	}

	public void Show(ShowShopTreasureChestFxParameter parameter)
	{
	}

	public DrawCardType GetCardTextureType(ItemInfo itemInfo)
	{
		return default(DrawCardType);
	}

	private void InitShowButtons()
	{
	}

	private void ShowDrawSingle()
	{
	}

	private void ShowDrawPack()
	{
	}

	private void ReplaceCards()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayDisable_003Ed__49))]
	private IEnumerator DelayDisable()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayReplace_003Ed__50))]
	private IEnumerator DelayReplace(int i, bool isHighGrade)
	{
		return null;
	}

	private void ActivateCards()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoFlipCard_003Ed__52))]
	private IEnumerator AutoFlipCard()
	{
		return null;
	}

	private void ClearCards()
	{
	}

	private void HideOpen()
	{
	}

	private void Update()
	{
	}

	private Transform[] GetAllJoints(Transform root)
	{
		return null;
	}

	private bool IsHighQualityCard(ItemInfo item)
	{
		return false;
	}

	private void ShuffleCards()
	{
	}
}
