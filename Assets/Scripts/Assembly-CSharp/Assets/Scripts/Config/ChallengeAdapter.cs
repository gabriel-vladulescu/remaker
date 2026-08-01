using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class ChallengeAdapter : Assets.Scripts.Ssar.Dungeon.Configs.Challenge
	{
		private global::Scripts.Config.Challenge rawChallenge;

		public ChallengeAdapter(global::Scripts.Config.Challenge rawChallenge)
		{
		}

		public int WaveOrder()
		{
			return 0;
		}

		public Assets.Scripts.Ssar.Dungeon.Configs.Trigger StartTrigger()
		{
			return null;
		}

		public Assets.Scripts.Ssar.Dungeon.Configs.Trigger MainTrigger()
		{
			return null;
		}
	}
}
