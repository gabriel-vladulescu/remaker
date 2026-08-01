using SSAR.Shop.Enum;

namespace Ssar.Main.View
{
	public class MainSceneButtonStore : MainSceneButton
	{
		public ShopTabType tabType;

		protected override void ShowPopup()
		{
		}

		protected override bool IsUnlock()
		{
			return false;
		}

		protected override LockType GetLockType()
		{
			return default(LockType);
		}

		protected override int LevelRequireUnlock()
		{
			return 0;
		}

		protected override string MapRequireUnlock()
		{
			return null;
		}
	}
}
