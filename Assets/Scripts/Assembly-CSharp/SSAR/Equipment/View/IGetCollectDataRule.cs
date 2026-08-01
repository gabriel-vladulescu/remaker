namespace SSAR.Equipment.View
{
	public interface IGetCollectDataRule
	{
		bool IsSuitableConditions(ICollectData collectData);
	}
}
