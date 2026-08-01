using Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Challenges
{
	public class DefaultChallenge : Challenge
	{
		private Trigger startTrigger;

		private Trigger mainTrigger;

		private NotNullReference notNullReference;

		public DefaultChallenge(Trigger startTrigger, Trigger mainTrigger)
		{
		}

		public bool IsFinished()
		{
			return false;
		}

		public void Update(float dt, int waveOrder)
		{
		}

		public string UnfinishedReason()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
