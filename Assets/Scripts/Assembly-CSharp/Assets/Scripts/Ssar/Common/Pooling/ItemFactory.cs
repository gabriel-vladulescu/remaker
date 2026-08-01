namespace Assets.Scripts.Ssar.Common.Pooling
{
	public interface ItemFactory
	{
		Item Produce(Definition definition, int itemIndex);
	}
}
