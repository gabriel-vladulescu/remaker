namespace SSAR.View
{
	public class ChallengeMapButtonBloodyTower : ChallengeMapButton
	{
		protected override void ShowPopup()
		{
		}

		protected override EffectPathIndex EffectIndex()
		{
			return default(EffectPathIndex);
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
