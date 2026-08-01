using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class CollectNewShardPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayPlayFxShard_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectNewShardPopup _003C_003E4__this;

			public MemoryShardInfo shardInfo;

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
			public _003CDelayPlayFxShard_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CEnableCamera3d_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectNewShardPopup _003C_003E4__this;

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
			public _003CEnableCamera3d_003Ed__30(int _003C_003E1__state)
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
		private sealed class _003CEnableWidgetInfo_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectNewShardPopup _003C_003E4__this;

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
			public _003CEnableWidgetInfo_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CInstantiateNewFx_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CollectNewShardPopup _003C_003E4__this;

			public MemoryShardInfo shardInfo;

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
			public _003CInstantiateNewFx_003Ed__24(int _003C_003E1__state)
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

		public float DELAY_PLAY_FX_NEW_SHARD;

		public float DELAY_CAN_CLOSE;

		public float DELAY_ENABLE_CAMERA3d;

		public float DELAY_ENABLE_INFO_CONTAINER;

		public float TWEEN_INFO_CONTAINER_DURATION;

		public float FX_SHARD_DURATION;

		public float DELAY_INSTANTIATE_FX;

		private float timePlayVfx;

		public GameObject wg_shard;

		public GameObject btn_mask;

		public GameObject wgContent;

		public UILabel lb_name;

		public UILabel lb_desc;

		public Camera container3d;

		public TweenAlpha tweenInfoContainer;

		public TweenPosition tweenShard;

		public GameObject flashFxContainer;

		private Action onFinish;

		private MirrorEffectView effectView;

		private float time;

		private bool hasPlayVfx;

		private MemoryShardConfig MemoryShardConfig => null;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(MemoryShardInfo shardInfo, Action onFinish)
		{
		}

		[IteratorStateMachine(typeof(_003CInstantiateNewFx_003Ed__24))]
		private IEnumerator InstantiateNewFx(MemoryShardInfo shardInfo)
		{
			return null;
		}

		private void UpdateText(MemoryShardInfo shardInfo)
		{
		}

		private void ClearOld()
		{
		}

		private void UpdateVisual(MirrorInfo info)
		{
		}

		private void Flash()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPlayFxShard_003Ed__29))]
		private IEnumerator DelayPlayFxShard(MemoryShardInfo shardInfo)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEnableCamera3d_003Ed__30))]
		private IEnumerator EnableCamera3d()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEnableWidgetInfo_003Ed__31))]
		private IEnumerator EnableWidgetInfo()
		{
			return null;
		}

		private void Update()
		{
		}

		public void Hide(GameObject o)
		{
		}

		private void InitBg()
		{
		}

		private void TweenShardPosition()
		{
		}

		private void InitFlash()
		{
		}
	}
}
