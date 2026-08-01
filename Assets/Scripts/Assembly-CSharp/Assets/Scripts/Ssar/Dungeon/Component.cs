namespace Assets.Scripts.Ssar.Dungeon
{
	public interface Component
	{
		void StartUp();

		void ShutDown();

		void Start();

		void Stop();

		void Update(float dt);
	}
}
