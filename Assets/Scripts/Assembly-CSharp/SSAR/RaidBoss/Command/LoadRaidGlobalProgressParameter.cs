using System;

namespace Ssar.RaidBoss.Command
{
	public class LoadRaidGlobalProgressParameter
	{
		public RaidDifficulty difficulty;

		public Action callback;

		public Action<string> failCallback;

		public LoadRaidGlobalProgressParameter(RaidDifficulty difficulty, Action callback, Action<string> failCallback)
		{
		}
	}
}
