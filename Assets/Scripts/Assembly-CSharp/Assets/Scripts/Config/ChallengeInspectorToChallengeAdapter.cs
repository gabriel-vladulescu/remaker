using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class ChallengeInspectorToChallengeAdapter : Challenge
	{
		private ChallengeInspector challengeInspector;

		private Trigger startTrigger;

		private Trigger mainTrigger;

		public ChallengeInspectorToChallengeAdapter(ChallengeInspector challengeInspector)
		{
		}

		public int WaveOrder()
		{
			return 0;
		}

		public Trigger StartTrigger()
		{
			return null;
		}

		public Trigger MainTrigger()
		{
			return null;
		}
	}
}
