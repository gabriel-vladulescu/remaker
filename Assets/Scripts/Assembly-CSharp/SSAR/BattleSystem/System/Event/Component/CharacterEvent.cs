using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace SSAR.BattleSystem.System.Event.Component
{
	public class CharacterEvent : Assets.Scripts.Ssar.Combat.HeroStateMachines.Event
	{
		private BeHitListener beHitListener;

		private DashEndListener dashEndListener;

		private FallEndListener fallEndListener;

		private DieListener dieListener;

		private event ModifierStateListener modifierStateListenerEvent;

		private event ResurrectionListener resurrectionListenerEvent;

		public void ListenToBeHit(BeHitListener listener)
		{
			beHitListener += listener;
		}

		public void UnlistenToBeHit(BeHitListener listener)
		{
			beHitListener -= listener;
		}

		public void NotifyBeHit(object source, EventArgs args)
		{
			if (beHitListener != null)
			{
				beHitListener(source, args);
			}
		}

		public void ListenToDashEnd(DashEndListener dashEndListener)
		{
			this.dashEndListener += dashEndListener;
		}

		public void UnlistenToDashEnd(DashEndListener dashEndListener)
		{
			this.dashEndListener -= dashEndListener;
		}

		public void NotifyDashEnd(object source, EventArgs args)
		{
			if (dashEndListener != null)
			{
				dashEndListener(source, args);
			}
		}

		public void ListenToFallEnd(FallEndListener listener)
		{
			fallEndListener += listener;
		}

		public void UnlistenToFallEnd(FallEndListener listener)
		{
			fallEndListener -= listener;
		}

		public void NotifyFallEnd(object source, EventArgs args)
		{
			if (fallEndListener != null)
			{
				fallEndListener(source, args);
			}
		}

		public void ListenToDie(DieListener listener)
		{
			dieListener += listener;
		}

		public void UnlistenToDie(DieListener listener)
		{
			dieListener -= listener;
		}

		public void NotifyDie(object source, EventArgs args)
		{
			if (dieListener != null)
			{
				dieListener(source, args);
			}
		}

		public void ListenToModifierState(ModifierStateListener listener)
		{
			modifierStateListenerEvent += listener;
		}

		public void UnlistenToModifierState(ModifierStateListener listener)
		{
			modifierStateListenerEvent -= listener;
		}

		public void NotifyModifierState(object source, EventArgs args)
		{
			if (modifierStateListenerEvent != null)
			{
				modifierStateListenerEvent(source, args);
			}
		}

		public void ListenToResurrection(ResurrectionListener listener)
		{
			resurrectionListenerEvent += listener;
		}

		public void UnlistenToResurrection(ResurrectionListener listener)
		{
			resurrectionListenerEvent -= listener;
		}

		public void NotifyResurrection(object source, EventArgs args)
		{
			if (resurrectionListenerEvent != null)
			{
				resurrectionListenerEvent(source, args);
			}
		}
	}
}
