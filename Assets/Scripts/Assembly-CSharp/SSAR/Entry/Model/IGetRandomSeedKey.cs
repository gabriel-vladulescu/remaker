namespace SSAR.Entry.Model
{
	public interface IGetRandomSeedKey
	{
		string GetKey();

		int RandomSeedInitBonusValue();
	}
}
