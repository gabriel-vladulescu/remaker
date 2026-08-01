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
using SSAR.BattleSystem.Camera;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Input;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using Ssar.Analytics.Metrics.Tutorial;
using UnityEngine;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class NewTutorialGroup0Logic : AbsTutorialGroup0Logic
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass106_0
		{
			public Action onFinishFadeIn;

			public NewTutorialGroup0Logic _003C_003E4__this;

			public float delayStartFadeOut;

			public float fadeOutDurtion;

			public Action onStartFadeOut;

			public Action onFinishFadeOut;

			internal void _003CFadeInOutScreen_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAutoRecoveryHp_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CAutoRecoveryHp_003Ed__86(int _003C_003E1__state)
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
		private sealed class _003CBossCastSkillStealthAttack_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CBossCastSkillStealthAttack_003Ed__60(int _003C_003E1__state)
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
		private sealed class _003CBossStealth_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CBossStealth_003Ed__68(int _003C_003E1__state)
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
		private sealed class _003CCheckDashReachPos_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

			private CharacterMediatorComponent _003CcharacterMediatorComponent_003E5__2;

			private CameraComponent _003CcameraComponent_003E5__3;

			private float _003Cgate2X_003E5__4;

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
			public _003CCheckDashReachPos_003Ed__49(int _003C_003E1__state)
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
		private sealed class _003CCheckEnemey_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CCheckEnemey_003Ed__36(int _003C_003E1__state)
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
		private sealed class _003CCheckEnemyAppear_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CCheckEnemyAppear_003Ed__50(int _003C_003E1__state)
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
		private sealed class _003CCheckFinishBossBattle_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

			private bool _003Cflag_003E5__2;

			private float _003Ctime_003E5__3;

			private float _003Cdt_003E5__4;

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
			public _003CCheckFinishBossBattle_003Ed__72(int _003C_003E1__state)
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
		private sealed class _003CCheckInputMove_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CCheckInputMove_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003CCheckJumpAttack_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CCheckJumpAttack_003Ed__47(int _003C_003E1__state)
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
		private sealed class _003CCheckMovePassNavigatorIE_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

			private CharacterMediatorComponent _003CcharacterMediatorComponent_003E5__2;

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
			public _003CCheckMovePassNavigatorIE_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CCheckProjectile_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CCheckProjectile_003Ed__39(int _003C_003E1__state)
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
		private sealed class _003CCheckThenCastBossSkillSpawn_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

			private bool _003Cflag_003E5__2;

			private float _003Ctime_003E5__3;

			private float _003Cdt_003E5__4;

			private UniversalInputSystem _003CuniversalInputSystem_003E5__5;

			private int _003CspawnCount_003E5__6;

			private int _003Ci_003E5__7;

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
			public _003CCheckThenCastBossSkillSpawn_003Ed__71(int _003C_003E1__state)
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
		private sealed class _003CCloneAndAddToHead_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutAnchorObject[] key;

			public float[] scale;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CCloneAndAddToHead_003Ed__87(int _003C_003E1__state)
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
		private sealed class _003CDelay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CDelay_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CDelayDispatchShowJoyStick_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CDelayDispatchShowJoyStick_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CDelayEnterRequireSkill_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CDelayEnterRequireSkill_003Ed__55(int _003C_003E1__state)
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
		private sealed class _003CDelayNextDialog_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CDelayNextDialog_003Ed__62(int _003C_003E1__state)
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
		private sealed class _003CDelayPauseDungeon_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CDelayPauseDungeon_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CDelayReleaseinput_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CDelayReleaseinput_003Ed__61(int _003C_003E1__state)
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
		private sealed class _003CEffectLevelUpIE_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CEffectLevelUpIE_003Ed__90(int _003C_003E1__state)
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
		private sealed class _003CFadeInOutScreen_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action onFinishFadeIn;

			public NewTutorialGroup0Logic _003C_003E4__this;

			public float delayStartFadeOut;

			public float fadeOutDurtion;

			public Action onStartFadeOut;

			public Action onFinishFadeOut;

			public float delayStartFadeIn;

			public Action onStartFadeIn;

			private _003C_003Ec__DisplayClass106_0 _003C_003E8__1;

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
			public _003CFadeInOutScreen_003Ed__106(int _003C_003E1__state)
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
		private sealed class _003CFadeOutScreen_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delayStartFadeOut;

			public Action onStartFadeOut;

			public Action OnFinishFadeOut;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CFadeOutScreen_003Ed__107(int _003C_003E1__state)
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
		private sealed class _003CShowSkill23IE_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CShowSkill23IE_003Ed__53(int _003C_003E1__state)
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
		private sealed class _003CSlowMotion_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CSlowMotion_003Ed__95(int _003C_003E1__state)
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
		private sealed class _003CStrartTrackingBossHpIe_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

			private HealthComponent _003ChealthComponent_003E5__2;

			private Animation _003Canim_003E5__3;

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
			public _003CStrartTrackingBossHpIe_003Ed__65(int _003C_003E1__state)
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
		private sealed class _003CWaitUntilBossFinishAnimation_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewTutorialGroup0Logic _003C_003E4__this;

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
			public _003CWaitUntilBossFinishAnimation_003Ed__69(int _003C_003E1__state)
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

		private Vector3 navigatorPos;

		private Vector3 posCompleteDash;

		private float gate1X;

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

		private TutorialStage stageUltimate;

		private GameObject navigator;

		private int enemyWave1;

		private int enemyStag2Wave1;

		private int enemyStag2Wave2;

		private float timeToSpawnSpider;

		private float hpToChangeScene;

		private float timeToForChangeScene;

		private SignalManager SignalManager => null;

		private DungeonSignalManager DungeonSignalManager => null;

		private Entity MainCharacterEntity => null;

		private EntityWorld EntityWorld => null;

		private DungeonDataManager DungeonDataManager => null;

		public NewTutorialGroup0Logic(TutorialGroup0 tutorialGroup0)
			: base(null)
		{
		}

		private void HideAllUI()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPauseDungeon_003Ed__23))]
		private IEnumerator DelayPauseDungeon()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__24))]
		private IEnumerator Delay()
		{
			return null;
		}

		private void ResumeDungeon(TutorialKey key, TutorialStage stage)
		{
		}

		private void SpawnNavigator()
		{
		}

		private void CheckMovePassNavigator(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckMovePassNavigatorIE_003Ed__28))]
		private IEnumerator CheckMovePassNavigatorIE()
		{
			return null;
		}

		private void CompleteMoveToNavigator()
		{
		}

		private void CheckWave1Spawn(TutorialKey key, TutorialStage tutorialStage)
		{
		}

		private void PauseDungeonUpdate(bool pause)
		{
		}

		private void JoyStickStart(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayDispatchShowJoyStick_003Ed__33))]
		private IEnumerator DelayDispatchShowJoyStick()
		{
			return null;
		}

		private void CheckInputMove(TutorialKey key, TutorialStage stage)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckInputMove_003Ed__35))]
		private IEnumerator CheckInputMove()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckEnemey_003Ed__36))]
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

		[IteratorStateMachine(typeof(_003CCheckProjectile_003Ed__39))]
		private IEnumerator CheckProjectile()
		{
			return null;
		}

		private void ListenEnterStage()
		{
		}

		private void CheckEnemyStage1Wave1Clear()
		{
		}

		private void CheckEnemyStage2Wave1Clear()
		{
		}

		private void CheckEnemyStage2Wave2Clear()
		{
		}

		private void ShowObjective()
		{
		}

		private void StartJump()
		{
		}

		private void ReenableAI()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckJumpAttack_003Ed__47))]
		private IEnumerator CheckJumpAttack()
		{
			return null;
		}

		private void StartJumpAttack()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckDashReachPos_003Ed__49))]
		private IEnumerator CheckDashReachPos()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckEnemyAppear_003Ed__50))]
		private IEnumerator CheckEnemyAppear(TutorialKey key)
		{
			return null;
		}

		private void CheckEnemyAppea2(TutorialKey key, TutorialStage stage)
		{
		}

		private void StartSkill1()
		{
		}

		[IteratorStateMachine(typeof(_003CShowSkill23IE_003Ed__53))]
		private IEnumerator ShowSkill23IE()
		{
			return null;
		}

		private void CheckAndReduceTreantHp()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayEnterRequireSkill_003Ed__55))]
		private IEnumerator DelayEnterRequireSkill()
		{
			return null;
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

		[IteratorStateMachine(typeof(_003CBossCastSkillStealthAttack_003Ed__60))]
		private IEnumerator BossCastSkillStealthAttack()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayReleaseinput_003Ed__61))]
		private IEnumerator DelayReleaseinput()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayNextDialog_003Ed__62))]
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

		[IteratorStateMachine(typeof(_003CStrartTrackingBossHpIe_003Ed__65))]
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

		[IteratorStateMachine(typeof(_003CBossStealth_003Ed__68))]
		private IEnumerator BossStealth()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitUntilBossFinishAnimation_003Ed__69))]
		private IEnumerator WaitUntilBossFinishAnimation(string animation, Action action)
		{
			return null;
		}

		private void FinishDialogAfterBossStealth()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckThenCastBossSkillSpawn_003Ed__71))]
		private IEnumerator CheckThenCastBossSkillSpawn()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckFinishBossBattle_003Ed__72))]
		private IEnumerator CheckFinishBossBattle()
		{
			return null;
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

		private void MetricCompleteCastSkill()
		{
		}

		private void MetricCompleteBossAppear()
		{
		}

		private void MetricCompleteShowUltimate()
		{
		}

		private void MetricCompleteCastUltimate()
		{
		}

		private void MetricCompleteBattle()
		{
		}

		private CombatTutorialData ObtainCombatTutorialData()
		{
			return null;
		}

		private void ShowDashButton()
		{
		}

		[IteratorStateMachine(typeof(_003CAutoRecoveryHp_003Ed__86))]
		private IEnumerator AutoRecoveryHp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloneAndAddToHead_003Ed__87))]
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

		[IteratorStateMachine(typeof(_003CEffectLevelUpIE_003Ed__90))]
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

		[IteratorStateMachine(typeof(_003CSlowMotion_003Ed__95))]
		private IEnumerator SlowMotion(float scaleTime, float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeInOutScreen_003Ed__106))]
		private IEnumerator FadeInOutScreen(float delayStartFadeIn, float delayStartFadeOut, float fadeInDuration, float fadeOutDurtion, Action onStartFadeIn, Action onStartFadeOut, Action onFinishFadeIn, Action onFinishFadeOut)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeOutScreen_003Ed__107))]
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
