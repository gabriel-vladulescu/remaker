namespace Assets.Scripts.Ssar.Dungeon.Stages.LosingConditions
{
	public interface LosingCondition
	{
		bool IsMet();

		void Update(float dt);
	}
}
