using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Utils;
using SSAR.BattleSystem.Camera;
using Scripts.Config;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.MemoryShard.Command
{
	public class ShowDropMemoryShardEffectCmd : strange.extensions.command.impl.Command
	{
		private delegate EaseMove AddEaseMoveToGameObject(GameObject go);

		[CompilerGenerated]
		private sealed class _003CDelayDisableCamera_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowDropMemoryShardEffectCmd _003C_003E4__this;

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
			public _003CDelayDisableCamera_003Ed__23(int _003C_003E1__state)
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

		private GameObject appearPrefab;

		private GameObject shardPrefab;

		private GameObject hitPrefab;

		private GameObject anchorPrefab;

		private GameObject scriptPrefab;

		[Inject]
		public MemoryShardInfo ShardInfo { get; set; }

		[Inject]
		public ResourcesLoader resourcesLoader { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem entryDefaultSystem { get; set; }

		public override void Execute()
		{
		}

		private void PreloadPopup()
		{
		}

		private void OnAssetLoaded()
		{
		}

		private Vector3 Destination(Vector3 heroPos, Vector3 deathPosOfBoss, Camera camera, Vector3 centerOffset)
		{
			return default(Vector3);
		}

		private void FinishFx()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayDisableCamera_003Ed__23))]
		private IEnumerator DelayDisableCamera()
		{
			return null;
		}

		private CameraComponent CameraComponent()
		{
			return null;
		}

		private void DisableUI(bool disable)
		{
		}

		private void StartDrop()
		{
		}

		private void EndDrop()
		{
		}
	}
}
