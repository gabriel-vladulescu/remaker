using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Core.Skills.Cooldowns;
using SSAR.BattleSystem.Input;
using SSAR.Dungeon.View;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class PetButtonSkillView : ButtonSkillView
	{
		[CompilerGenerated]
		private sealed class _003CCastSkill_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PetButtonSkillView _003C_003E4__this;

			private UniversalInputSystem _003CuniversalInputSystem_003E5__2;

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
			public _003CCastSkill_003Ed__4(int _003C_003E1__state)
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

		public UISprite sp_icon;

		private Entity entity;

		private PetSkillStats petSkillStats;

		protected override void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CCastSkill_003Ed__4))]
		private IEnumerator CastSkill()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		public void Init(Entity entity)
		{
		}

		public void UpdateData()
		{
		}

		protected override void ObserverOnCastSkill(int entityId, string skillId)
		{
		}

		protected override float GetCooldown()
		{
			return 0f;
		}

		public void Hide(bool hide)
		{
		}

		private Cooldown GetCooldownData()
		{
			return null;
		}
	}
}
