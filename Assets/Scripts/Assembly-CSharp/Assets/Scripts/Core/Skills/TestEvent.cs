using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace Assets.Scripts.Core.Skills
{
	internal class TestEvent : Event
	{
		private bool beHit;

		private event BeHitListener beHitEvent;

		private event DashEndListener dashEndEvent;

		private event FallEndListener fallEndEvent;

		public void Update(float dt)
		{
		}

		public void LateUpdate()
		{
		}

		private void Input()
		{
		}

		public void ListenToBeHit(BeHitListener listener)
		{
		}

		public void UnlistenToBeHit(BeHitListener listener)
		{
		}

		public void NotifyBeHit(object source, EventArgs args)
		{
		}

		public void ListenToDashEnd(DashEndListener dashEndListener)
		{
		}

		public void UnlistenToDashEnd(DashEndListener dashEndListener)
		{
		}

		public void NotifyDashEnd(object source, EventArgs args)
		{
		}

		public void ListenToFallEnd(FallEndListener listener)
		{
		}

		public void UnlistenToFallEnd(FallEndListener listener)
		{
		}

		public void NotifyFallEnd(object source, EventArgs args)
		{
		}

		public void ListenToDie(DieListener listener)
		{
		}

		public void UnlistenToDie(DieListener listener)
		{
		}

		public void NotifyDie(object source, EventArgs args)
		{
		}

		public void ListenToModifierState(ModifierStateListener listener)
		{
		}

		public void UnlistenToModifierState(ModifierStateListener listener)
		{
		}

		public void NotifyModifierState(object source, EventArgs args)
		{
		}

		public void ListenToResurrection(ResurrectionListener listener)
		{
		}

		public void UnlistenToResurrection(ResurrectionListener listener)
		{
		}

		public void NotifyResurrection(object source, EventArgs args)
		{
		}
	}
}
