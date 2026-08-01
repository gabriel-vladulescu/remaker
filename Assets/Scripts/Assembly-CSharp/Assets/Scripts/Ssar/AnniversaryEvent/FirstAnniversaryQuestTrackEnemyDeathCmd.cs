using Artemis;
using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryQuestTrackEnemyDeathCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		public override void Execute()
		{
		}

		private void Listener(Entity entity)
		{
		}
	}
}
