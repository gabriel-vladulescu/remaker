using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers
{
	public interface Trigger
	{
		bool IsFinished();

		void Update(float dt, int waveOrder);

		void SetEnv(Assets.Scripts.Ssar.Dungeon.Environment.Environment env);

		void SetCookies(IEnumerable<string> cookies);

		string UnfinishedReason();
	}
}
