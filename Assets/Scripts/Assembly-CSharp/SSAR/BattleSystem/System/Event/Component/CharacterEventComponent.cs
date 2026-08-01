using Artemis.Interface;

namespace SSAR.BattleSystem.System.Event.Component
{
	public class CharacterEventComponent : IComponent
	{
		public CharacterEvent characterEvent;

		public CharacterEventComponent(CharacterEvent ev)
		{
			characterEvent = ev;
		}

		public void NotifyExitfall()
		{
			characterEvent.NotifyFallEnd(this, global::System.EventArgs.Empty);
		}

		public void NotifyExitDash()
		{
			characterEvent.NotifyDashEnd(this, global::System.EventArgs.Empty);
		}

		public void NotifyDeath()
		{
			characterEvent.NotifyDie(this, global::System.EventArgs.Empty);
		}
	}
}
