using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Artemis.Utils;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Dungeon.Signal;
using Assets.Scripts.Ssar.Signal;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using Spine.Unity;
using Ssar.Analytics.Metrics.Tutorial;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class OldTutorialGroup0Logic : AbsTutorialGroup0Logic
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass82_0
		{
			public Action onFinishFadeIn;

			public OldTutorialGroup0Logic _003C_003E4__this;

			public float delayStartFadeOut;

			public float fadeOutDurtion;

			public Action onStartFadeOut;

			public Action onFinishFadeOut;

			internal void _003CFadeInOutScreen_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAutoRecoveryHp_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			private Entity _003Cmain_003E5__2;

			private Character _003Cc_003E5__3;

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
			public _003CAutoRecoveryHp_003Ed__62(int _003C_003E1__state)
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
		private sealed class _003CCheckEnemey_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private Bag<Entity> _003Cbag_003E5__2;

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
			public _003CCheckEnemey_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CCheckEnemyAppear_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			public TutorialKey key;

			private bool _003Cflag_003E5__2;

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
			public _003CCheckEnemyAppear_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CCheckInputMove_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			private CharacterInputComponent _003CcharacterInputComponent_003E5__2;

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
			public _003CCheckInputMove_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CCheckJumpAttack_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			private bool _003Cflag_003E5__2;

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
			public _003CCheckJumpAttack_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CCheckProjectile_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			private bool _003Cflag_003E5__2;

			private CharacterMediatorComponent _003CmediatorComponent_003E5__3;

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
			public _003CCheckProjectile_003Ed__25(int _003C_003E1__state)
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
		private sealed class _003CCloneAndAddToHead_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutAnchorObject[] key;

			public float[] scale;

			public OldTutorialGroup0Logic _003C_003E4__this;

			public string text;

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
			public _003CCloneAndAddToHead_003Ed__63(int _003C_003E1__state)
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
		private sealed class _003CDelay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
		private sealed class _003CDelayDispatchShowJoyStick_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CDelayDispatchShowJoyStick_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CDelayNextDialog_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

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
			public _003CDelayNextDialog_003Ed__42(int _003C_003E1__state)
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
		private sealed class _003CDelayPauseDungeon_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

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
			public _003CDelayPauseDungeon_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CDelayReleaseinput_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

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
			public _003CDelayReleaseinput_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CEffectLevelUpIE_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CEffectLevelUpIE_003Ed__66(int _003C_003E1__state)
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
		private sealed class _003CFadeInOutScreen_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action onFinishFadeIn;

			public OldTutorialGroup0Logic _003C_003E4__this;

			public float delayStartFadeOut;

			public float fadeOutDurtion;

			public Action onStartFadeOut;

			public Action onFinishFadeOut;

			public float delayStartFadeIn;

			public Action onStartFadeIn;

			private _003C_003Ec__DisplayClass82_0 _003C_003E8__1;

			public float fadeInDuration;

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
			public _003CFadeInOutScreen_003Ed__82(int _003C_003E1__state)
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
		private sealed class _003CFadeOutScreen_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delayStartFadeOut;

			public Action onStartFadeOut;

			public Action OnFinishFadeOut;

			public OldTutorialGroup0Logic _003C_003E4__this;

			public float fadeOutDuration;

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
			public _003CFadeOutScreen_003Ed__83(int _003C_003E1__state)
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
		private sealed class _003CSlowMotion_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float scaleTime;

			public float duration;

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
			public _003CSlowMotion_003Ed__71(int _003C_003E1__state)
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
		private sealed class _003CStrartTrackingBossHpIe_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			private HealthComponent _003ChealthComponent_003E5__2;

			private SkeletonAnimation _003CskeletonAnimation_003E5__3;

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
			public _003CStrartTrackingBossHpIe_003Ed__45(int _003C_003E1__state)
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
		private sealed class _003CWaitUntilBossFinishAnimation_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OldTutorialGroup0Logic _003C_003E4__this;

			public string animation;

			public Action action;

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
			public _003CWaitUntilBossFinishAnimation_003Ed__49(int _003C_003E1__state)
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

		private DungeonSignalManager _dungeonSignalManager;

		private bool enableAutoRecoveryHp;

		private bool hasTriggerBossHp;

		private Entity boss;

		private bool hasSpawn;

		private bool hasInvokeListenDash;

		private TutorialStage stageDash0;

		private TutorialStage stageDash;

		private TutorialStage stageJump;

		private TutorialStage stageSkill;

		private SignalManager SignalManager => null;

		private DungeonSignalManager DungeonSignalManager => null;

		private Entity MainCharacterEntity => null;

		private EntityWorld EntityWorld => null;

		private DungeonDataManager DungeonDataManager => null;

		public OldTutorialGroup0Logic(TutorialGroup0 tutorialGroup0)
			: base(null)
		{
		}

		private void HideAllUI()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPauseDungeon_003Ed__12))]
		private IEnumerator DelayPauseDungeon()
		{
			return null;
		}

		private void Complete1(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__14))]
		private IEnumerator Delay()
		{
			return null;
		}

		private void FadeOut(TutorialKey key, TutorialStage stage)
		{
		}

		private void ResumeDungeon(TutorialKey key, TutorialStage stage)
		{
		}

		private void PauseDungeonUpdate(bool pause)
		{
		}

		private void JoyStickStart(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayDispatchShowJoyStick_003Ed__19))]
		private IEnumerator DelayDispatchShowJoyStick()
		{
			return null;
		}

		private void CompleteMove(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckInputMove_003Ed__21))]
		private IEnumerator CheckInputMove()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckEnemey_003Ed__22))]
		private IEnumerator CheckEnemey()
		{
			return null;
		}

		private void StartStepAttack()
		{
		}

		private void CompleteEnterStage(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckProjectile_003Ed__25))]
		private IEnumerator CheckProjectile()
		{
			return null;
		}

		private void ListenEnterStage()
		{
		}

		private void StartJump()
		{
		}

		private void ReenableAI()
		{
		}

		private void CheckFinishDash()
		{
		}

		private void FinishJump()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckJumpAttack_003Ed__31))]
		private IEnumerator CheckJumpAttack()
		{
			return null;
		}

		private void StartJumpAttack()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckEnemyAppear_003Ed__33))]
		private IEnumerator CheckEnemyAppear(TutorialKey key)
		{
			return null;
		}

		private void CheckEnemyAppea2(TutorialKey key, TutorialStage stage)
		{
		}

		private void StartSkill()
		{
		}

		private void CheckFinishSkill(TutorialKey key, TutorialStage stage)
		{
		}

		private void FinishSkill()
		{
		}

		private void CheckClearAllEnemeyStage3()
		{
		}

		private void FadeInScreenBeforeSpawnBoss()
		{
		}

		private void SpawnBossAndCastSkill()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayReleaseinput_003Ed__41))]
		private IEnumerator DelayReleaseinput()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayNextDialog_003Ed__42))]
		private IEnumerator DelayNextDialog()
		{
			return null;
		}

		private void ListenerMainCharacterBeDealDamage(int entityId, int casterId, float damage, DamageSource damageSource)
		{
		}

		private void BossAppearFinish()
		{
		}

		[IteratorStateMachine(typeof(_003CStrartTrackingBossHpIe_003Ed__45))]
		private IEnumerator StrartTrackingBossHpIe()
		{
			return null;
		}

		private void BossHpTrigger()
		{
		}

		private void PrepareStealth(Action finish)
		{
		}

		private void BossStealth()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitUntilBossFinishAnimation_003Ed__49))]
		private IEnumerator WaitUntilBossFinishAnimation(string animation, Action action)
		{
			return null;
		}

		private void FinishDialogAfterBossStealth()
		{
		}

		private void StartCombatTut()
		{
		}

		private void MetricCompleteFirstDialog()
		{
		}

		private void MetricCompleteMove()
		{
		}

		private void MetricCompleteAttack()
		{
		}

		private void MetricCompleteDash()
		{
		}

		private void MetricCompleteJumpAttack()
		{
		}

		private void MetricCompleteBossAppear()
		{
		}

		private void MetricCompleteKillBoss()
		{
		}

		private void MetricCompleteVictoryPopup()
		{
		}

		private CombatTutorialData ObtainCombatTutorialData()
		{
			return null;
		}

		private void ShowDashButton()
		{
		}

		[IteratorStateMachine(typeof(_003CAutoRecoveryHp_003Ed__62))]
		private IEnumerator AutoRecoveryHp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloneAndAddToHead_003Ed__63))]
		private IEnumerator CloneAndAddToHead(TutAnchorObject[] key, float[] scale, string text)
		{
			return null;
		}

		private void CloneAndAddToHead(TutAnchorObject key, float scale, string text)
		{
		}

		private void EffectLevelUp()
		{
		}

		[IteratorStateMachine(typeof(_003CEffectLevelUpIE_003Ed__66))]
		private IEnumerator EffectLevelUpIE()
		{
			return null;
		}

		private void PauseDungeon()
		{
		}

		private void ResumeDungeon()
		{
		}

		private void DisableUICamera1(bool disable)
		{
		}

		private void DisableMainCharacterInput(bool disable)
		{
		}

		[IteratorStateMachine(typeof(_003CSlowMotion_003Ed__71))]
		private IEnumerator SlowMotion(float scaleTime, float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeInOutScreen_003Ed__82))]
		private IEnumerator FadeInOutScreen(float delayStartFadeIn, float delayStartFadeOut, float fadeInDuration, float fadeOutDurtion, Action onStartFadeIn, Action onStartFadeOut, Action onFinishFadeIn, Action onFinishFadeOut)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeOutScreen_003Ed__83))]
		private IEnumerator FadeOutScreen(float delayStartFadeOut, float fadeOutDuration, Action onStartFadeOut, Action OnFinishFadeOut)
		{
			return null;
		}

		private AbsCharacterDialogTutorialGroup0 GetDialog()
		{
			return null;
		}
	}
}
