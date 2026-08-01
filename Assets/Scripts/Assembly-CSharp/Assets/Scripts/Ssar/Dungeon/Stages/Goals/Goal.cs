namespace Assets.Scripts.Ssar.Dungeon.Stages.Goals
{
	public interface Goal
	{
		bool IsAchieved();

		void Update(float dt);

		void OnAddedToStage(DefaultStage stage);

		string Reason();
	}
}
