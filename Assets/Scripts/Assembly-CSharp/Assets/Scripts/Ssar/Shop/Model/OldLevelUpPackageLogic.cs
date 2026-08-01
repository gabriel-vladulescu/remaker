using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class OldLevelUpPackageLogic : ILevelUpPackageLogic
	{
		private AbsCardViewParameter parameter;

		public OldLevelUpPackageLogic(ConfigManager configManager)
		{
		}

		public AbsCardViewParameter CardViewParameter()
		{
			return null;
		}
	}
}
