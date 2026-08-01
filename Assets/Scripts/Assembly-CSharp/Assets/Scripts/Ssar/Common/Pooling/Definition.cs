namespace Assets.Scripts.Ssar.Common.Pooling
{
	public interface Definition
	{
		int Id();

		int Size();

		bool Expandable();

		Item Object();
	}
}
