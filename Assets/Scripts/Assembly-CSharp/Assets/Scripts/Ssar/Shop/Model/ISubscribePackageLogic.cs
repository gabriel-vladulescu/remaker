namespace Assets.Scripts.Ssar.Shop.Model
{
	public interface ISubscribePackageLogic
	{
		bool IsBought();

		AbsCardViewParameter CardViewParameter();

		ISubscribeBoughtInfo BoughtInfo();
	}
}
