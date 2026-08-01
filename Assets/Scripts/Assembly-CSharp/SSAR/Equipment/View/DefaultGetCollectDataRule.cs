namespace SSAR.Equipment.View
{
	public class DefaultGetCollectDataRule : IGetCollectDataRule
	{
		public bool suitable;

		public DefaultGetCollectDataRule RejectAll()
		{
			return null;
		}

		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}
	}
}
