namespace SSAR.Equipment.View
{
	public interface IOverlay
	{
		void OnEnable();

		void OnDisable();

		bool IsEnable();

		int Priority();
	}
}
