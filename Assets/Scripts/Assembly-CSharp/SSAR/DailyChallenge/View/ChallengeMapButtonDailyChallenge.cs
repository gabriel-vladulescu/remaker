using SSAR.View;

namespace Ssar.DailyChallenge.View
{
	public class ChallengeMapButtonDailyChallenge : ChallengeMapButton
	{
		public override void Check()
		{
		}

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
