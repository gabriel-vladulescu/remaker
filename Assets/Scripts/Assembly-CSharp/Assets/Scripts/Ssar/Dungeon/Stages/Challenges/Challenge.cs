namespace Assets.Scripts.Ssar.Dungeon.Stages.Challenges
{
	public interface Challenge
	{
		bool IsFinished();

		void Update(float dt, int waveOrder);

		string UnfinishedReason();
	}
}
