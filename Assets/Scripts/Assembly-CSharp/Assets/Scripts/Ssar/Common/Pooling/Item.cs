namespace Assets.Scripts.Ssar.Common.Pooling
{
	public interface Item
	{
		bool IsActive();

		void OnObtain();

		void OnReturn();
	}
}
