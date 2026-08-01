using System;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public interface Event
	{
		void ListenToDashEnd(DashEndListener dashEndListener);

		void UnlistenToDashEnd(DashEndListener dashEndListener);

		void NotifyDashEnd(object source, EventArgs args);

		void ListenToFallEnd(FallEndListener listener);

		void UnlistenToFallEnd(FallEndListener listener);

		void NotifyFallEnd(object source, EventArgs args);

		void ListenToDie(DieListener listener);

		void UnlistenToDie(DieListener listener);

		void NotifyDie(object source, EventArgs args);

		void ListenToModifierState(ModifierStateListener listener);

		void UnlistenToModifierState(ModifierStateListener listener);

		void NotifyModifierState(object source, EventArgs args);

		void ListenToResurrection(ResurrectionListener listener);

		void UnlistenToResurrection(ResurrectionListener listener);

		void NotifyResurrection(object source, EventArgs args);
	}
}
