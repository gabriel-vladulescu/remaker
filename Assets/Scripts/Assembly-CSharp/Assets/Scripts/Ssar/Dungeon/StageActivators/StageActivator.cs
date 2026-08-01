namespace Assets.Scripts.Ssar.Dungeon.StageActivators
{
	public interface StageActivator
	{
		bool IsActive();

		void Update(float dt);

		void Activate();

		void Deactivate();
	}
}
